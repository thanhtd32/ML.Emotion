using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML.Emotion.Data;
using ML.Emotion.Error;
using Newtonsoft.Json;

namespace ML.Emotion.Common
{
    public class DatasetParser
    {
        public static List<FeedbackData> LoadData(string path)
        {
            List<FeedbackData>? data = null;

            try
            {
                string json = ParseJson(path);
                data = JsonConvert.DeserializeObject<List<FeedbackData>>(json);
            }
            catch(Exception ex)
            {
                throw new EmotionError(ex.Message);
            }
            return data;
        }
        private static string ParseJson(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }
       
    }
}
