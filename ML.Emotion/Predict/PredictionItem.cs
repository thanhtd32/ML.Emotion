using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Emotion.Predict
{
    public class PredictionItem
    {
        public string PredictedLabel;
        public float Score;
        public int OriginalSchemaIndex;
        public PredictionItem()
        { }
        public PredictionItem(string predictedLabel, float score, int originalSchemaIndex)
        {
            PredictedLabel = predictedLabel;
            Score = score;
            OriginalSchemaIndex = originalSchemaIndex;
        }
    }
}
