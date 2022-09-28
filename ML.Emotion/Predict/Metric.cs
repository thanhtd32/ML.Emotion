using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Emotion.Predict
{
    public class Metric
    {
        public double MacroAccuracy { get; set; }
        public double MicroAccuracy { get; set; }
        public double LogLoss { get; set; }
        public double LogLossReduction { get; set; }
        public IReadOnlyList<double> PerClassLogLoss { get; set; }
        public string ConfusionMatrixFormat { get; set; }
        public IReadOnlyList<IReadOnlyList<double>> Counts{ get; set; }
        public int NumberOfClasses { get; set; }
        public IReadOnlyList<double> PerClassPrecision { get; set; }
        public IReadOnlyList<double> PerClassRecall { get; set; }
        public double Accuracy { get; set; }
        public double F1_Score_Compliment { get; set; }
        public double F1_Score_Neutral { get; set; }
        public double F1_Score_Blame { get; set; }
        public Metric(MulticlassClassificationMetrics metrics)
        {
            MacroAccuracy=metrics.MacroAccuracy;
            MicroAccuracy=metrics.MicroAccuracy;
            Accuracy = MicroAccuracy;
            LogLoss =metrics.LogLoss;
            LogLossReduction=metrics.LogLossReduction;
            PerClassLogLoss =metrics.PerClassLogLoss;
            ConfusionMatrixFormat = metrics.ConfusionMatrix.GetFormattedConfusionTable();
            Counts = metrics.ConfusionMatrix.Counts;
            NumberOfClasses = metrics.ConfusionMatrix.NumberOfClasses;
            PerClassPrecision = metrics.ConfusionMatrix.PerClassPrecision;
            PerClassRecall = metrics.ConfusionMatrix.PerClassRecall;
            F1_Score_Compliment = 2 * (PerClassPrecision[0] * PerClassRecall[0]) / (PerClassPrecision[0] + PerClassRecall[0]);
            F1_Score_Neutral = 2 * (PerClassPrecision[1] * PerClassRecall[1]) / (PerClassPrecision[1] + PerClassRecall[1]);
            F1_Score_Blame = 2 * (PerClassPrecision[2] * PerClassRecall[2]) / (PerClassPrecision[2] + PerClassRecall[2]);
        }
    }
}
