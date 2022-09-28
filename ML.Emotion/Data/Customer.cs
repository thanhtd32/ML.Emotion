using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Emotion.Data
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<CustomerFeedback> CustomerFeedbacks { get; set; }
        public Customer()
        {
            CustomerFeedbacks = new List<CustomerFeedback>();
        }
    }
}
