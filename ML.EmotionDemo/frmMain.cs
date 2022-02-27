using ML.Emotion.Data;
using ML.Emotion.Predict;

namespace ML.EmotionDemo
{
    public partial class frmMain : Form
    {
        //Declare EmotionEngine object
        EmotionEngine emotionEngine =new EmotionEngine();
        string folder = "Models";
        public frmMain()
        {
            InitializeComponent();
        }
    
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadModelIntoCombo();
        }
        //1. Import dataset and split traint- test set
        private void btnLoadData_Click(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path=openFileDialog1.FileName;
                double ratio=double.Parse(txtTestRatio.Text);
                emotionEngine.ImportDataset(path, false, ratio);
            }
        }
        //2. Build model
        private void btnBuildModel_Click(object sender, EventArgs e)
        {
            bool ret=emotionEngine.BuildAndTrainModel();
            if (ret)
                lblBuildModelStatus.Text = "Build Model successfully";
            else
                lblBuildModelStatus.Text = "Build Model failed";
        }
        //3. Evaluate model
        private void btnEvaluateModel_Click(object sender, EventArgs e)
        {
            Metric metric= emotionEngine.Evaluate();
            txtAccuracy.Text=Math.Round(metric.Accuracy,2).ToString();
            txtAUC_PR.Text= Math.Round(metric.AUC_PR, 2).ToString();
            txtAUC_ROC.Text= Math.Round(metric.AUC_ROC, 2).ToString();
            txtF1Score.Text= Math.Round(metric.F1Score, 2).ToString();  
            txtLogLoss.Text= Math.Round(metric.LogLoss, 2).ToString();
            txtLogLossReduction.Text= Math.Round(metric.LogLossReduction, 2).ToString();
            txtNegativePrecision.Text= Math.Round(metric.NegativePrecision, 2).ToString();
            txtNegativeRecall.Text= Math.Round(metric.NegativeRecall, 2).ToString();    
            txtPositivePrecision.Text= Math.Round(metric.PositivePrecision, 2).ToString();
            txtPositiveRecall.Text = Math.Round(metric.PositiveRecall, 2).ToString();
        }
        //4. Save model
        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folder) == false)
            {
                Directory.CreateDirectory(folder);
            }
            string path = folder + "\\ML.Emotion-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".zip";
            bool ret = emotionEngine.SaveModel(path);
            if (ret)
                lblSaveModelStatus.Text = "Save Model successfully";
            else
                lblSaveModelStatus.Text = "Save Model failed";
            LoadModelIntoCombo();
        }
        //5. Load model
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
        //5. Load model and pick model
        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            if (cboModel.SelectedIndex == -1)
                return;
            string modelName = folder + "\\" + cboModel.Text;
            bool ret = emotionEngine.LoadModel(modelName);
            if (ret)
                lblLoadModelStatus.Text = "Load Model successfully";
            else
                lblLoadModelStatus.Text = "Load Model failed";
        }
        //6. Predict
        private void btnPredict_Click(object sender, EventArgs e)
        {
            FeedbackData feedback=new FeedbackData();
            feedback.Data=txtInputData.Text;
            EmotionDataPrediction result = emotionEngine.Predict(feedback);
            
            picBlameArrow.Visible = false;
            lblBlameProbability.Visible = false;

            picComplimentArrow.Visible = false;
            lblComplimentProbability.Visible = false;

            picNeutralArrow.Visible = false;
            lblNeutralProbability.Visible = false;
            if(result.EmotionType==EmotionType.Blame)
            {
                picBlameArrow.Visible = true;
                lblBlameProbability.Visible = true;
                lblBlameProbability.Text = "Probability:" + result.ProbabilityFormat;
            }
            else if(result.EmotionType==EmotionType.Neutral)
            {
                picNeutralArrow.Visible = true;
                lblNeutralProbability.Visible = true;
                lblNeutralProbability.Text = "Probability:" + result.ProbabilityFormat;
            }
            else if(result.EmotionType== EmotionType.Compliment)
            {
                picComplimentArrow.Visible = true;
                lblComplimentProbability.Visible = true;
                lblComplimentProbability.Text = "Probability:" + result.ProbabilityFormat;
            }
        }
    }
}