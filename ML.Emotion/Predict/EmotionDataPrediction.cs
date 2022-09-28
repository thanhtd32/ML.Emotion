using Microsoft.ML.Data;

namespace ML.Emotion.Predict
{
    public class EmotionDataPrediction
    {
        [ColumnName("PredictedLabel")]
        public string EmotionLabel;
        [ColumnName("Score")]
        public float[] Score;

        public EmotionType EmotionType
        {
            get
            {
                if (EmotionLabel == EmotionType.Blame.ToString())
                    return EmotionType.Blame;
                if (EmotionLabel == EmotionType.Compliment.ToString())
                    return EmotionType.Compliment;
                return EmotionType.Neutral;
            }
        }
        public float Probability;
        public VBuffer<ReadOnlyMemory<char>> labels = default;
    }
}
