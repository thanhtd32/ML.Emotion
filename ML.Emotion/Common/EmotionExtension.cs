using Microsoft.ML.Data;
using ML.Emotion.Predict;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Emotion.Common
{
    public static class EmotionExtension
    {
        public static (PredictionItem, PredictionItem, PredictionItem) BuildPredictionItems(this EmotionDataPrediction edp)
        {
            float[] scores = edp.Score;
            int size = scores.Length;
            int index0, index1, index2 = 0;

            GetIndexesOfTopThreeScores(scores, size, out index0, out index1, out index2);

            PredictionItem[] FullPredictions = new PredictionItem[]
                {
                    new PredictionItem(edp.labels.GetItemOrDefault(index0).ToString(),scores[index0],index0),
                    new PredictionItem(edp.labels.GetItemOrDefault(index1).ToString(),scores[index1],index1),
                    new PredictionItem(edp.labels.GetItemOrDefault(index2).ToString(),scores[index2],index2)
                };
            foreach (PredictionItem fp in FullPredictions)
            {
                if (fp.PredictedLabel == edp.EmotionLabel)
                {
                    edp.Probability= fp.Score;
                    break;
                }
            }
            PredictionItem Blame = new PredictionItem();
            PredictionItem Neutral = new PredictionItem();
            PredictionItem Compliment = new PredictionItem();
            foreach (PredictionItem fp in FullPredictions)
            {
                if (fp.PredictedLabel == EmotionType.Blame.ToString())
                {
                    Blame = fp;
                }
                else if (fp.PredictedLabel == EmotionType.Neutral.ToString())
                {
                    Neutral = fp;
                }
                else if (fp.PredictedLabel == EmotionType.Compliment.ToString())
                {
                    Compliment = fp;
                }
            }
            return (Blame, Neutral, Compliment);
        }
        static void GetIndexesOfTopThreeScores(float[] scores, int n, out int index0, out int index1, out int index2)
        {
            int i;
            float first, second, third;
            index0 = index1 = index2 = 0;
            if (n < 3)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            third = first = second = 000;
            for (i = 0; i < n; i++)
            {
                // If current element is  
                // smaller than first 
                if (scores[i] > first)
                {
                    third = second;
                    second = first;
                    first = scores[i];
                }
                // If arr[i] is in between first 
                // and second then update second 
                else if (scores[i] > second)
                {
                    third = second;
                    second = scores[i];
                }

                else if (scores[i] > third)
                    third = scores[i];
            }
            var scoresList = scores.ToList();
            index0 = scoresList.IndexOf(first);
            index1 = scoresList.IndexOf(second);
            index2 = scoresList.IndexOf(third);
        }
    }
}
