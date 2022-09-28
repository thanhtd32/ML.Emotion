using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Emotion.Error
{
    public class EmotionError:ApplicationException
    {
        public string message { get; set; }
        public EmotionError(string message)
        {
            this.message = message;
        }
    }
}
