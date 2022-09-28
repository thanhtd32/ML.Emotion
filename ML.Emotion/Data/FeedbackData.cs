using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Emotion.Data
{
    public class FeedbackData
    {
        public string Business_Id;
        public string Date;
        public string Review_Id;
        public string Stars;
        public string Text;
        public string Type;
        public string User_Id;        
        public string Cool;
        public string Useful;
        public string Funny;
        public string EmotionLabel;
    }
}
