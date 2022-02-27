using ML.Emotion.Data;
using ML.Emotion.Predict;

namespace ML.EmotionDemo
{
    public partial class frmMain : Form
    {
        EmotionEngine emotionEngine=new EmotionEngine();
        string folder = "Models";
        public frmMain()
        {
            InitializeComponent();
        }
        string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "yelp_labelled.txt");

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadModelIntoCombo();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path=openFileDialog1.FileName;
                double ratio=double.Parse(txtTestRatio.Text);
                emotionEngine.ImportDataset(path, false, ratio);
            }
        }

        private void btnBuildModel_Click(object sender, EventArgs e)
        {
            bool ret=emotionEngine.BuildAndTrainModel();
            if (ret)
                lblBuildModelStatus.Text = "Build Model successfully";
            else
                lblBuildModelStatus.Text = "Build Model failed";
        }

        private void btnEvaluateModel_Click(object sender, EventArgs e)
        {
            Metric metric= emotionEngine.Evaluate();
            txtAccuracy.Text=metric.Accuracy.ToString();
            txtAUC_PR.Text=metric.AUC_PR.ToString();
            txtAUC_ROC.Text=metric.AUC_ROC.ToString();
            txtF1Score.Text=metric.F1Score.ToString();  
            txtLogLoss.Text=metric.LogLoss.ToString();
            txtLogLossReduction.Text=metric.LogLossReduction.ToString();
            txtNegativePrecision.Text=metric.NegativePrecision.ToString();
            txtNegativeRecall.Text=metric.NegativeRecall.ToString();    
            txtPositivePrecision.Text=metric.PositivePrecision.ToString();
            txtPositiveRecall.Text = metric.PositiveRecall.ToString();
        }

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