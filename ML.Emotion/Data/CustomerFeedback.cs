using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Emotion.Data
{
    public class CustomerFeedback
    {
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public FeedbackData Feedback { get; set; }
        public DateTime FeedbackDate { get; set; }
    }
}
