using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML.Emotion.Data;
using ML.Emotion.Predict;
using ML.Emotion.Classify;
using ML.Emotion.Common;
namespace ML.EmotionDemo
{
    public partial class frmListClassify : Form
    {
        public frmListClassify()
        {
            InitializeComponent();
        }
        List<Customer> customerList = new List<Customer>();
        List<Product> productList = new List<Product>();

        private void btnCreateData_Click(object sender, EventArgs e)
        {
           
        }
        void createListOfCustomer()
        {
            Customer c1 = new Customer();
            c1.CustomerId = "CUS-1";
            c1.CustomerName = "Peter";
            customerList.Add(c1);

            Customer c2 = new Customer();
            c2.CustomerId = "CUS-2";
            c2.CustomerName = "John";
            customerList.Add(c2);

            Customer c3 = new Customer();
            c3.CustomerId = "CUS-3";
            c3.CustomerName = "Daisy";
            customerList.Add(c3);

            Customer c4 = new Customer();
            c4.CustomerId = "CUS-4";
            c4.CustomerName = "Tom";
            customerList.Add(c4);

            Customer c5 = new Customer();
            c5.CustomerId = "CUS-5";
            c5.CustomerName = "Loren";
            customerList.Add(c5);

            Customer c6 = new Customer();
            c6.CustomerId = "CUS-6";
            c6.CustomerName = "Sara";
            customerList.Add(c6);

            Customer c7 = new Customer();
            c7.CustomerId = "CUS-7";
            c7.CustomerName = "Hara";
            customerList.Add(c7);

            Customer c8 = new Customer();
            c8.CustomerId = "CUS-8";
            c8.CustomerName = "Chan";
            customerList.Add(c8);

            Customer c9 = new Customer();
            c9.CustomerId = "CUS-9";
            c9.CustomerName = "Swit";
            customerList.Add(c9);

            Customer c10 = new Customer();
            c10.CustomerId = "CUS-10";
            c10.CustomerName = "Lan";
            customerList.Add(c10);
        }
        EmotionEngine emotionEngine = new EmotionEngine();
        string folder = "Models";
        private void LoadModelIntoCombo()
        {
            cboModel.Items.Clear();

            if (Directory.Exists(folder) == false)
            {
                return;
            }
            string[] files = Directory.GetFiles(folder);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                cboModel.Items.Add(fi.Name);
            }
        }
        private void frmListClassify_Load(object sender, EventArgs e)
        {
            LoadModelIntoCombo();
            createListOfCustomer();
            createListOfProduct();
            customerList[0].CustomerFeedbacks = new List<CustomerFeedback>();
            
            CustomerFeedback f0 = new CustomerFeedback();
            f0.Product = productList[0];
            f0.Feedback = new FeedbackData() { Text = "I will never eat pasta second time" };
            f0.Customer = customerList[0];
            customerList[0].CustomerFeedbacks.Add(f0);

            CustomerFeedback f1 = new CustomerFeedback();
            f1.Product = productList[1];
            f1.Feedback = new FeedbackData() { Text = "you should try French Fries, it is ok" };
            f1.Customer = customerList[0];
            customerList[0].CustomerFeedbacks.Add(f1);

            CustomerFeedback f2 = new CustomerFeedback();
            f2.Product = productList[2];
            f2.Feedback = new FeedbackData() { Text = "The ice cream i think it is very delicious" };
            f2.Customer = customerList[0];
            customerList[0].CustomerFeedbacks.Add(f2);

            CustomerFeedback f3 = new CustomerFeedback();
            f3.Product = productList[3];
            f3.Feedback = new FeedbackData() { Text = "The bread is normal" };
            f3.Customer = customerList[0];
            customerList[0].CustomerFeedbacks.Add(f3);

            CustomerFeedback f4 = new CustomerFeedback();
            f4.Product = productList[4];
            f4.Feedback = new FeedbackData() { Text = "wow, Fried rice is delicious" };
            f4.Customer = customerList[0];
            customerList[0].CustomerFeedbacks.Add(f4);

            CustomerFeedback f5 = new CustomerFeedback();
            f5.Product = productList[5];
            f5.Feedback = new FeedbackData() { Text = "I don't like pancakes" };
            f5.Customer = customerList[0];
            customerList[0].CustomerFeedbacks.Add(f5);

            CustomerFeedback f6 = new CustomerFeedback();
            f6.Product = productList[6];
            f6.Feedback = new FeedbackData() { Text = "Burger i have no idea" };
            f6.Customer = customerList[0];
            customerList[0].CustomerFeedbacks.Add(f6);

            CustomerFeedback f = new CustomerFeedback();
            f.Product = productList[6];
            f.Feedback = new FeedbackData() { Text = "I don't like Burger" };
            f.Customer = customerList[1];
            customerList[1].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[9];
            f.Feedback = new FeedbackData() { Text = "ohm my god, it is very delicious, you should try it" };
            f.Customer = customerList[1];
            customerList[1].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[8];
            f.Feedback = new FeedbackData() { Text = "I will invite my friend to try this good, it is ok" };
            f.Customer = customerList[1];
            customerList[1].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[5];
            f.Feedback = new FeedbackData() { Text = "Actually, I have no idea for this food" };
            f.Customer = customerList[2];
            customerList[2].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[5];
            f.Feedback = new FeedbackData() { Text = "i like it" };
            f.Customer = customerList[3];
            customerList[3].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[9];
            f.Feedback = new FeedbackData() { Text = "Honeslty it didn't" };
            f.Customer = customerList[3];
            customerList[3].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[7];
            f.Feedback = new FeedbackData() { Text = "do not buy it" };
            f.Customer = customerList[3];
            customerList[3].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[8];
            f.Feedback = new FeedbackData() { Text = "Overall, I like this product a lot." };
            f.Customer = customerList[4];
            customerList[4].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[9];
            f.Feedback = new FeedbackData() { Text = "it is very expensive" };
            f.Customer = customerList[5];
            customerList[5].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[9];
            f.Feedback = new FeedbackData() { Text = "We'll never go again." };
            f.Customer = customerList[6];
            customerList[6].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[4];
            f.Feedback = new FeedbackData() { Text = "say good bye" };
            f.Customer = customerList[6];
            customerList[6].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[5];
            f.Feedback = new FeedbackData() { Text = "It was not good." };
            f.Customer = customerList[7];
            customerList[7].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[9];
            f.Feedback = new FeedbackData() { Text = "They have a good selection" };
            f.Customer = customerList[7];
            customerList[7].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[1];
            f.Feedback = new FeedbackData() { Text = "Good Service-check!" };
            f.Customer = customerList[7];
            customerList[7].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[1];
            f.Feedback = new FeedbackData() { Text = "Wow... Loved this place" };
            f.Customer = customerList[8];
            customerList[8].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[3];
            f.Feedback = new FeedbackData() { Text = "Would not go back." };
            f.Customer = customerList[8];
            customerList[8].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[6];
            f.Feedback = new FeedbackData() { Text = "Highly recommended." };
            f.Customer = customerList[8];
            customerList[8].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[7];
            f.Feedback = new FeedbackData() { Text = "There is not a deal good " };
            f.Customer = customerList[8];
            customerList[8].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[6];
            f.Feedback = new FeedbackData() { Text = "Not much ok" };
            f.Customer = customerList[9];
            customerList[9].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[2];
            f.Feedback = new FeedbackData() { Text = "A great way to buy." };
            f.Customer = customerList[9];
            customerList[9].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[6];
            f.Feedback = new FeedbackData() { Text = "Really, really good " };
            f.Customer = customerList[9];
            customerList[9].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[9];
            f.Feedback = new FeedbackData() { Text = "It was not good." };
            f.Customer = customerList[9];
            customerList[9].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[7];
            f.Feedback = new FeedbackData() { Text = "Unfortunately, it only set us up for disapppointment " };
            f.Customer = customerList[9];
            customerList[9].CustomerFeedbacks.Add(f);

            f = new CustomerFeedback();
            f.Product = productList[6];
            f.Feedback = new FeedbackData() { Text = "I like so much, i will return back" };
            f.Customer = customerList[4];
            customerList[4].CustomerFeedbacks.Add(f);

            loadListCustomerOnListView();
        }
        void createListOfProduct()
        {
            productList.Add(new Product() { ProductId="P-1",ProductName= "Pasta" });
            productList.Add(new Product() { ProductId = "P-2", ProductName = "French Fries" });
            productList.Add(new Product() { ProductId = "P-3", ProductName = "Ice Cream" });
            productList.Add(new Product() { ProductId = "P-4", ProductName = "Bread" });
            productList.Add(new Product() { ProductId = "P-5", ProductName = "Fried Rice" });
            productList.Add(new Product() { ProductId = "P-6", ProductName = "Pancakes" });
            productList.Add(new Product() { ProductId = "P-7", ProductName = "Burger" });
            productList.Add(new Product() { ProductId = "P-8", ProductName = "Steak" });
            productList.Add(new Product() { ProductId = "P-9", ProductName = "Bacon" });
            productList.Add(new Product() { ProductId = "P-10", ProductName = "Turkey" });
            /*productList.Add(new Product() { ProductId = "P-11", ProductName = "Banana" });
            productList.Add(new Product() { ProductId = "P-12", ProductName = "Apple Pie" });
            productList.Add(new Product() { ProductId = "P-13", ProductName = "Bagel" });
            productList.Add(new Product() { ProductId = "P-14", ProductName = "Muffins" });
            productList.Add(new Product() { ProductId = "P-15", ProductName = "Alfredo Sauce" });
            productList.Add(new Product() { ProductId = "P-16", ProductName = "Reece's Peanut Cups" });
            productList.Add(new Product() { ProductId = "P-17", ProductName = "Ice Cream Cake" });
            productList.Add(new Product() { ProductId = "P-18", ProductName = "Cheesecake" });
            productList.Add(new Product() { ProductId = "P-19", ProductName = "Cheese" });
            productList.Add(new Product() { ProductId = "P-20", ProductName = "Banana Bread" });
            productList.Add(new Product() { ProductId = "P-21", ProductName = "Steak" });
            productList.Add(new Product() { ProductId = "P-22", ProductName = "Ribs" });
            productList.Add(new Product() { ProductId = "P-23", ProductName = "Grilled Chicken" }); 
            productList.Add(new Product() { ProductId = "P-24", ProductName = "Hot Dogs" });
            productList.Add(new Product() { ProductId = "P-25", ProductName = "Bacon" });
            productList.Add(new Product() { ProductId = "P-26", ProductName = "Brownies" });
            productList.Add(new Product() { ProductId = "P-27", ProductName = "Donuts" });
            productList.Add(new Product() { ProductId = "P-28", ProductName = "Turkey" });
            productList.Add(new Product() { ProductId = "P-29", ProductName = "Lamb Chops" });*/
        }
        void loadListCustomerOnListView()
        {
            foreach(Customer c in customerList)
            {
                ListViewItem lvi = new ListViewItem(c.CustomerId);
                lvi.SubItems.Add(c.CustomerName);
                lvi.Tag = c;
                lvCustomer.Items.Add(lvi);
            }
        }

        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCustomer.SelectedItems.Count <= 0) return;
            ListViewItem lvi = lvCustomer.SelectedItems[0];
            Customer c =(Customer) lvi.Tag;
            if (c.CustomerFeedbacks == null) return;
            lvProduct.Items.Clear();
            foreach(CustomerFeedback cf in c.CustomerFeedbacks)
            {
                ListViewItem lvpi = new ListViewItem(cf.Product.ProductId);
                lvpi.SubItems.Add(cf.Product.ProductName);
                EmotionDataPrediction edp = emotionEngine.Predict(cf.Feedback);
                edp.BuildPredictionItems();
                lvpi.SubItems.Add(edp.EmotionType.ToString());
                lvpi.SubItems.Add(String.Format("{0:0.00}%", edp.Probability* 100));
                lvpi.Tag= cf.Feedback;
                lvProduct.Items.Add(lvpi);
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            if (cboModel.SelectedIndex == -1)
                return;
            string modelName = folder + "\\" + cboModel.Text;
            bool ret = emotionEngine.LoadModel(modelName);
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count <= 0) return;
            ListViewItem lvi=lvProduct.SelectedItems[0];
            FeedbackData fd=lvi.Tag as FeedbackData;
            txtReview.Text = fd.Text;
        }
    }
}
