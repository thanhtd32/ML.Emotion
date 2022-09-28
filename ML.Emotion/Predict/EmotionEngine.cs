using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.Text;
using ML.Emotion.Common;
using ML.Emotion.Data;
using ML.Emotion.Error;
using static Microsoft.ML.DataOperationsCatalog;
namespace ML.Emotion.Predict
{
    public class EmotionEngine 
    {
        
        private MLContext mlContext;
        private TrainTestData splitDataView;
        private ITransformer trainedModel;
       
        public EmotionEngine()
        {
            mlContext = new MLContext();
        }

        public List<FeedbackData> ImportDataset(string path,int seed=0,double testRatio=0.2)
        {
            try
            {
                mlContext = new MLContext(seed: seed);//seed:1
                List <FeedbackData> data = DatasetParser.LoadData(path);
                foreach(var item in data)
                {
                   
                    //item.Text = item.Text.TextCleaning();
                    string s = "this is ";
                    if(item.Stars=="1")
                    {
                        item.Stars = "one";
                    }
                    else if(item.Stars=="2")
                    {
                        item.Stars = "two";
                    }
                    else if (item.Stars == "3")
                    {
                        item.Stars = "three";
                    }
                    else if (item.Stars == "4")
                    {
                        item.Stars = "four";
                    }
                    else if (item.Stars == "5")
                    {
                        item.Stars = "five";
                    }
                    item.Stars = s + item.Stars;
                }
                // STEP 1: Common data loading configuration
                var dataView = mlContext.Data.LoadFromEnumerable(data);

                splitDataView = mlContext.Data.TrainTestSplit(dataView, testFraction: testRatio, seed: seed);
                
                return data;
            }
            catch (Exception ex)
            {
                throw new EmotionError(ex.Message);
            }          
        }
        //SDCA/OVA,["Text", "Stars"], "EmotionLabel"
        private bool  BuildAndTrainModel_(TrainerType trainerType,string []features, string label)
        {
            try
            {
                // STEP 2: Common data process configuration with pipeline data transformations

                var dataProcessPipeline = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "Label", inputColumnName: nameof(FeedbackData.EmotionLabel))
                            .Append(mlContext.Transforms.Text.FeaturizeText(outputColumnName: "ReviewFeaturized", inputColumnName: nameof(FeedbackData.Text)))
                            .Append(mlContext.Transforms.Concatenate(outputColumnName: "Features", "ReviewFeaturized"))
                            .AppendCacheCheckpoint(mlContext);

                // STEP 3: Create the selected training algorithm/trainer
                IEstimator<ITransformer> trainer = null;
                switch (trainerType)
                {
                    case TrainerType.SDCA:
                        trainer = mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features");
                        break;
                    case TrainerType.OVA:
                        {
                            // Create a binary classification trainer.
                            var averagedPerceptronBinaryTrainer = mlContext.BinaryClassification.Trainers.AveragedPerceptron("Label", "Features", numberOfIterations: 10);
                            // Compose an OVA (One-Versus-All) trainer with the BinaryTrainer.
                            // In this strategy, a binary classification algorithm is used to train one classifier for each class, "
                            // which distinguishes that class from all other classes. Prediction is then performed by running these binary classifiers, "
                            // and choosing the prediction with the highest confidence score.
                            trainer = mlContext.MulticlassClassification.Trainers.OneVersusAll(averagedPerceptronBinaryTrainer);

                            break;
                        }
                    default:
                        break;
                }
                //Set the trainer/algorithm and map label to value (original readable state)
                var trainingPipeline = dataProcessPipeline.Append(trainer)
                        .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

                
                // STEP 4: Train the model fitting to the DataSet
                Console.WriteLine("=============== Training the model ===============");
                trainedModel = trainingPipeline.Fit(splitDataView.TrainSet);

                // (OPTIONAL) Try/test a single prediction with the "just-trained model" (Before saving the model)
                var issue = new FeedbackData() { Stars = "5", Text = "great!" };
                // Create prediction engine related to the loaded trained model
                var predEngine = mlContext.Model.CreatePredictionEngine<FeedbackData, EmotionDataPrediction>(trainedModel);
                //Score
                var prediction = predEngine.Predict(issue);
                Console.WriteLine($"=============== Single Prediction just-trained-model - Result: {prediction.EmotionLabel} ===============");
                

                return true;
            }catch (Exception ex)
            {
                throw new EmotionError(ex.Message);
            }
        }
        public bool BuildAndTrainModel(TrainerType trainerType, string[] features, string label)
        {
            try
            {
                // STEP 2: Common data process configuration with pipeline data transformations

                var pipeline = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "Label", inputColumnName: label);
                EstimatorChain<ITransformer> estimatorChain = null;
                List<string> outFeatures = new List<string>();

                var options = new TextFeaturizingEstimator.Options()
                {
                    // Also output tokenized words
                    OutputTokensColumnName = "OutputTokens",
                    CaseMode = TextNormalizingEstimator.CaseMode.Lower,
                    // Use ML.NET's built-in stop word remover
                   /* StopWordsRemoverOptions = new StopWordsRemovingEstimator.Options()
                    {
                        Language = TextFeaturizingEstimator.Language.English
                    },*/

                    WordFeatureExtractor = new WordBagEstimator.Options()
                    {
                        NgramLength = 2,
                        UseAllLengths = true,
                        Weighting = NgramExtractingEstimator.WeightingCriteria.TfIdf, // TF-IDF
                    },

                    CharFeatureExtractor = new WordBagEstimator.Options()
                    {
                        NgramLength = 3,
                        UseAllLengths = false,
                        Weighting = NgramExtractingEstimator.WeightingCriteria.TfIdf, // TF-IDF
                    },
                    KeepPunctuations = false,
                    KeepNumbers = false
                };
                //options = null;
                foreach (var feature in features)
                {
                    if (estimatorChain == null)
                        //estimatorChain = pipeline.Append(mlContext.Transforms.Text.FeaturizeText(outputColumnName: feature + "Featurized", inputColumnName: feature));
                        estimatorChain = pipeline.Append(mlContext.Transforms.Text.FeaturizeText(outputColumnName: feature + "Featurized", options, feature));
                    else
                        //estimatorChain = estimatorChain.Append(mlContext.Transforms.Text.FeaturizeText(outputColumnName: feature + "Featurized", inputColumnName: feature));
                        estimatorChain = estimatorChain.Append(mlContext.Transforms.Text.FeaturizeText(outputColumnName: feature + "Featurized", options, feature));
                    outFeatures.Add(feature + "Featurized");
                }
                var columnEstimatorChain = estimatorChain.Append(mlContext.Transforms.Concatenate(outputColumnName: "Features", outFeatures.ToArray()));
                var dataProcessPipeline = columnEstimatorChain.AppendCacheCheckpoint(mlContext);

                // STEP 3: Create the selected training algorithm/trainer
                IEstimator<ITransformer> trainer = null;
                switch (trainerType)
                {
                    case TrainerType.SDCA:
                        trainer = mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features");
                        break;
                    case TrainerType.OVA:
                        {
                            // Create a binary classification trainer.
                            var averagedPerceptronBinaryTrainer = mlContext.BinaryClassification.Trainers.AveragedPerceptron("Label", "Features", numberOfIterations: 10);
                            // Compose an OVA (One-Versus-All) trainer with the BinaryTrainer.
                            // In this strategy, a binary classification algorithm is used to train one classifier for each class, "
                            // which distinguishes that class from all other classes. Prediction is then performed by running these binary classifiers, "
                            // and choosing the prediction with the highest confidence score.
                            trainer = mlContext.MulticlassClassification.Trainers.OneVersusAll(averagedPerceptronBinaryTrainer);

                            break;
                        }
                    default:
                        break;
                }
                //Set the trainer/algorithm and map label to value (original readable state)
                var trainingPipeline = dataProcessPipeline.Append(trainer)
                        .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));


                // STEP 4: Train the model fitting to the DataSet
                Console.WriteLine("=============== Training the model ===============");
                trainedModel = trainingPipeline.Fit(splitDataView.TrainSet);

                // (OPTIONAL) Try/test a single prediction with the "just-trained model" (Before saving the model)
                var issue = new FeedbackData() { Stars = "5", Text = "great!" };
                // Create prediction engine related to the loaded trained model
                var predEngine = mlContext.Model.CreatePredictionEngine<FeedbackData, EmotionDataPrediction>(trainedModel);
                //Score
                var prediction = predEngine.Predict(issue);
                Console.WriteLine($"=============== Single Prediction just-trained-model - Result: {prediction.EmotionLabel} ===============");
                //

                return true;
            }
            catch (Exception ex)
            {
                throw new EmotionError(ex.Message);
            }
        }
        public Metric Evaluate(IDataView testSet)
        {
            try
            {
                IDataView predictions = trainedModel.Transform(testSet);

                MulticlassClassificationMetrics metrics = mlContext.MulticlassClassification.Evaluate(predictions);
                
                return new Metric(metrics);
            }
            catch(Exception ex)
            {
                throw new EmotionError(ex.Message);
            }           
        }
        public Metric Evaluate()
        {
            try
            {
                IDataView predictions = trainedModel.Transform(splitDataView.TestSet);

                MulticlassClassificationMetrics metrics = mlContext.MulticlassClassification.Evaluate(predictions);
                

                return new Metric(metrics);
            }
            catch (Exception ex)
            {
                throw new EmotionError(ex.Message);
            }
        }
        public bool SaveModel(string modelFileName)
        {
            try
            {
                if (mlContext == null || trainedModel == null || splitDataView.TrainSet == null)
                    return false;
                mlContext.Model.Save(
                    trainedModel,
                    splitDataView.TrainSet.Schema,
                    modelFileName);
                return true;
            }
            catch (Exception ex)
            {
                throw new EmotionError(ex.Message);
            }
        }
        public bool LoadModel(string modelFileName)
        {
            try
            {
                if (mlContext == null)
                    return false;
                DataViewSchema modelSchema;
                trainedModel = mlContext.Model.Load(
                    modelFileName, 
                    out modelSchema);
                return true;
            }
            catch (Exception ex){
                throw new EmotionError(ex.Message);
            }
        }
        public EmotionDataPrediction Predict(FeedbackData inputData)
        {
            try{
                PredictionEngine<FeedbackData, EmotionDataPrediction> 
                predictionFunction =mlContext.Model.CreatePredictionEngine
                              <FeedbackData, EmotionDataPrediction>(trainedModel);
                inputData.Text = inputData.Text.TextCleaning();
                var resultPrediction = predictionFunction.Predict(inputData);
                
                VBuffer<ReadOnlyMemory<char>> labels = default;
                predictionFunction.OutputSchema[nameof(EmotionDataPrediction.Score)].GetSlotNames(ref labels);

                resultPrediction.labels = labels;

                return resultPrediction;
            }
            catch (Exception ex){
                throw new EmotionError(ex.Message);
            }           
        }


        public List<EmotionDataPrediction> Predict(List<FeedbackData> inputDatas)
        {
            List < EmotionDataPrediction > predictions = new List < EmotionDataPrediction >();
            try
            {
                PredictionEngine<FeedbackData, EmotionDataPrediction>
                predictionFunction = mlContext.Model.CreatePredictionEngine
                              <FeedbackData, EmotionDataPrediction>(trainedModel);

                VBuffer<ReadOnlyMemory<char>> labels = default;
                predictionFunction.OutputSchema[nameof(EmotionDataPrediction.Score)].GetSlotNames(ref labels);

                
                foreach (var inputData in inputDatas)
                {
                    var resultPrediction = predictionFunction.Predict(inputData);
                    resultPrediction.labels = labels;
                    predictions.Add(resultPrediction);
                }                

                return predictions;
            }
            catch (Exception ex)
            {
                throw new EmotionError(ex.Message);
            }
        }
     
    }
}
