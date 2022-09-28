using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Emotion.Data
{
    public class Product
    {
        public Product()
        {
            CustomerFeedbacks = new List<CustomerFeedback>(); ;
        }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public List<CustomerFeedback> CustomerFeedbacks { get; set; }
    }
}
