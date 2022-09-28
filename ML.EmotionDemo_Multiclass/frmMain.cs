using ML.Emotion.Data;
using ML.Emotion.Predict;
using ML.Emotion.Common;
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

            lblCount00.Text ="";
            lblCount01.Text ="";
            lblCount02.Text ="";
            lblRecall0.Text ="";

            lblCount10.Text ="";
            lblCount11.Text ="";
            lblCount12.Text ="";
            lblRecall1.Text ="";

            lblCount20.Text ="";
            lblCount21.Text ="";
            lblCount22.Text ="";
            lblRecall2.Text ="";

            lblPrecision0.Text = "";
            lblPrecision1.Text = "";
            lblPrecision2.Text = "";
        }
        //1. Import dataset and split traint- test set
        private void btnLoadData_Click(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path=openFileDialog1.FileName;
                int seed = int.Parse(txtSeed.Text);
                double ratio=double.Parse(txtTestRatio.Text);
                emotionEngine.ImportDataset(path,seed:seed, testRatio: ratio);
            }
        }
        //2. Build model
        private void btnBuildModel_Click(object sender, EventArgs e)
        {
            TrainerType trainerType = TrainerType.SDCA;
            if (radSDCA.Checked)
                trainerType = TrainerType.SDCA;
            else
                trainerType = TrainerType.OVA;
            bool ret=emotionEngine.BuildAndTrainModel(trainerType, new string[] { "Text" }, "EmotionLabel");
            string msg = "";
            if (ret)
                msg = "Build Model successfully";
            else
                msg = "Build Model failed";
            lblTrainStatus.Text = msg;
            MessageBox.Show(msg);
        }
        //3. Evaluate model
        Metric metric = null;
        private void btnEvaluateModel_Click(object sender, EventArgs e)
        {
            metric= emotionEngine.Evaluate();
            txtMacroAccuracy.Text=Math.Round(metric.MacroAccuracy,2).ToString();
            txtMicroAccuracy.Text= Math.Round(metric.MicroAccuracy, 2).ToString();
            txtLogLoss.Text= Math.Round(metric.LogLoss, 2).ToString();
            
            lblCount00.Text = metric.Counts[0][0] + "";
            lblCount01.Text = metric.Counts[0][1] + "";
            lblCount02.Text = metric.Counts[0][2] + "";
            lblRecall0.Text = String.Format("{0:0.0000}", metric.PerClassRecall[0]);

            lblCount10.Text = metric.Counts[1][0] + "";
            lblCount11.Text = metric.Counts[1][1] + "";
            lblCount12.Text = metric.Counts[1][2] + "";
            lblRecall1.Text = String.Format("{0:0.0000}", metric.PerClassRecall[1]);

            lblCount20.Text = metric.Counts[2][0] + "";
            lblCount21.Text = metric.Counts[2][1] + "";
            lblCount22.Text = metric.Counts[2][2] + "";
            lblRecall2.Text = String.Format("{0:0.0000}", metric.PerClassRecall[2]);

            lblPrecision0.Text = String.Format("{0:0.0000}", metric.PerClassPrecision[0]);
            lblPrecision1.Text = String.Format("{0:0.0000}", metric.PerClassPrecision[1]);
            lblPrecision2.Text = String.Format("{0:0.0000}", metric.PerClassPrecision[2]);
        }
        //4. Save model
        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folder) == false)
            {
                Directory.CreateDirectory(folder);
            }
            string trainalgorithm = "OVA_"+txtTestRatio.Text+"_";
            if(radSDCA.Checked==true)
                trainalgorithm = "SDCA_" + txtTestRatio.Text + "_";
            string path = folder + "\\ML.Emotion_" + trainalgorithm+ DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".zip";
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
            feedback.Text=txtInputData.Text;
            EmotionDataPrediction result = emotionEngine.Predict(feedback);
            var (blame, neutral, compliment) = result.BuildPredictionItems();
            lblBlameProbability.Text = String.Format("{0:0.0000}%", blame.Score*100);
            lblNeutralProbability.Text = String.Format("{0:0.0000}%", neutral.Score * 100);
            lblComplimentProbability.Text = String.Format("{0:0.0000}%", compliment.Score * 100);

        }

        private void picVoice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("deepspeech/DeepSpeech.WPF.exe");
        }

        private void lblConfusionTable_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(metric.ConfusionMatrixFormat);
            MessageBox.Show("Clipboard OK");
        }

        private void lblProbabilityClassify_Click(object sender, EventArgs e)
        {
            frmListClassify frm = new frmListClassify();
            frm.Show();
        }
    }
}