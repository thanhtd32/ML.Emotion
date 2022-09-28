using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML.Emotion.Data;
using ML.Emotion.Predict;
namespace ML.Emotion.Classify
{
    public class CustomerEmotionClassify
    {
        List<Customer> Classify(string model, Product p,EmotionType type)
        {
            List<Customer>customers = new List<Customer>();
            EmotionEngine engine = new EmotionEngine();
            engine.LoadModel(model);  
            foreach(CustomerFeedback cf in p.CustomerFeedbacks)
            {
                EmotionDataPrediction edp = engine.Predict(cf.Feedback);
                if(edp.EmotionLabel== type.ToString())
                {
                    customers.Add(cf.Customer);
                }
            }
            return customers;
        }       
        List<Product> Classify(string model, Customer c, EmotionType type)
        {
            List<Product> products= new List<Product>();
            EmotionEngine engine = new EmotionEngine();
            engine.LoadModel(model);
            foreach (CustomerFeedback cf in c.CustomerFeedbacks)
            {
                EmotionDataPrediction edp = engine.Predict(cf.Feedback);
                if (edp.EmotionLabel == type.ToString())
                {
                    products.Add(cf.Product);
                }
            }
            return products;
        }
    }
}
