namespace ML.EmotionDemo
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnPredict = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputData = new System.Windows.Forms.TextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnBuildModel = new System.Windows.Forms.Button();
            this.btnEvaluateModel = new System.Windows.Forms.Button();
            this.btnSaveModel = new System.Windows.Forms.Button();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picBlame = new System.Windows.Forms.PictureBox();
            this.picNeutral = new System.Windows.Forms.PictureBox();
            this.picCompliment = new System.Windows.Forms.PictureBox();
            this.txtMacroAccuracy = new System.Windows.Forms.TextBox();
            this.txtMicroAccuracy = new System.Windows.Forms.TextBox();
            this.txtLogLoss = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTestRatio = new System.Windows.Forms.TextBox();
            this.lblEvaluateModelStatus = new System.Windows.Forms.Label();
            this.lblSaveModelStatus = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.lblBlameProbability = new System.Windows.Forms.Label();
            this.lblNeutralProbability = new System.Windows.Forms.Label();
            this.lblComplimentProbability = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblLoadModelStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRecall2 = new System.Windows.Forms.Label();
            this.lblRecall1 = new System.Windows.Forms.Label();
            this.lblRecall0 = new System.Windows.Forms.Label();
            this.lblPrecision2 = new System.Windows.Forms.Label();
            this.lblCount22 = new System.Windows.Forms.Label();
            this.lblCount12 = new System.Windows.Forms.Label();
            this.lblCount02 = new System.Windows.Forms.Label();
            this.lblPrecision1 = new System.Windows.Forms.Label();
            this.lblCount21 = new System.Windows.Forms.Label();
            this.lblCount11 = new System.Windows.Forms.Label();
            this.lblCount01 = new System.Windows.Forms.Label();
            this.lblPrecision0 = new System.Windows.Forms.Label();
            this.lblCount20 = new System.Windows.Forms.Label();
            this.lblCount10 = new System.Windows.Forms.Label();
            this.lblCount00 = new System.Windows.Forms.Label();
            this.lblConfusionTable = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.picVoice = new System.Windows.Forms.PictureBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radOVA = new System.Windows.Forms.RadioButton();
            this.radSDCA = new System.Windows.Forms.RadioButton();
            this.lblTrainStatus = new System.Windows.Forms.Label();
            this.lblProbabilityClassify = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBlame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNeutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompliment)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPredict
            // 
            this.btnPredict.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_prediction;
            this.btnPredict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPredict.Location = new System.Drawing.Point(23, 130);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(132, 30);
            this.btnPredict.TabIndex = 20;
            this.btnPredict.Text = "6.Predict Emotion";
            this.btnPredict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(67, 86);
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(320, 23);
            this.txtInputData.TabIndex = 19;
            this.txtInputData.Text = "This was a horrible meal";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_import;
            this.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.Location = new System.Drawing.Point(184, 15);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(234, 30);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "1.Import Dataset && split train test set ";
            this.btnLoadData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnBuildModel
            // 
            this.btnBuildModel.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_buil_model;
            this.btnBuildModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuildModel.Location = new System.Drawing.Point(41, 99);
            this.btnBuildModel.Name = "btnBuildModel";
            this.btnBuildModel.Size = new System.Drawing.Size(151, 30);
            this.btnBuildModel.TabIndex = 4;
            this.btnBuildModel.Text = "2.Train Model";
            this.btnBuildModel.UseVisualStyleBackColor = true;
            this.btnBuildModel.Click += new System.EventHandler(this.btnBuildModel_Click);
            // 
            // btnEvaluateModel
            // 
            this.btnEvaluateModel.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_evaluate;
            this.btnEvaluateModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluateModel.Location = new System.Drawing.Point(11, 19);
            this.btnEvaluateModel.Name = "btnEvaluateModel";
            this.btnEvaluateModel.Size = new System.Drawing.Size(132, 30);
            this.btnEvaluateModel.TabIndex = 5;
            this.btnEvaluateModel.Text = "3.Evaluate Model";
            this.btnEvaluateModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEvaluateModel.UseVisualStyleBackColor = true;
            this.btnEvaluateModel.Click += new System.EventHandler(this.btnEvaluateModel_Click);
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_savemodel;
            this.btnSaveModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveModel.Location = new System.Drawing.Point(6, 352);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(127, 30);
            this.btnSaveModel.TabIndex = 16;
            this.btnSaveModel.Text = "4.Save Model";
            this.btnSaveModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_openmodel;
            this.btnLoadModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadModel.Location = new System.Drawing.Point(22, 32);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(124, 30);
            this.btnLoadModel.TabIndex = 17;
            this.btnLoadModel.Text = "5.Load Model";
            this.btnLoadModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Macro Accuracy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Micro Accuracy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Log Loss:";
            // 
            // picBlame
            // 
            this.picBlame.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_angry;
            this.picBlame.Location = new System.Drawing.Point(164, 130);
            this.picBlame.Name = "picBlame";
            this.picBlame.Size = new System.Drawing.Size(33, 35);
            this.picBlame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlame.TabIndex = 7;
            this.picBlame.TabStop = false;
            // 
            // picNeutral
            // 
            this.picNeutral.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_neutral;
            this.picNeutral.Location = new System.Drawing.Point(244, 130);
            this.picNeutral.Name = "picNeutral";
            this.picNeutral.Size = new System.Drawing.Size(33, 35);
            this.picNeutral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNeutral.TabIndex = 7;
            this.picNeutral.TabStop = false;
            // 
            // picCompliment
            // 
            this.picCompliment.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_love;
            this.picCompliment.Location = new System.Drawing.Point(326, 130);
            this.picCompliment.Name = "picCompliment";
            this.picCompliment.Size = new System.Drawing.Size(33, 35);
            this.picCompliment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompliment.TabIndex = 7;
            this.picCompliment.TabStop = false;
            // 
            // txtMacroAccuracy
            // 
            this.txtMacroAccuracy.Location = new System.Drawing.Point(12, 79);
            this.txtMacroAccuracy.Name = "txtMacroAccuracy";
            this.txtMacroAccuracy.Size = new System.Drawing.Size(70, 23);
            this.txtMacroAccuracy.TabIndex = 6;
            // 
            // txtMicroAccuracy
            // 
            this.txtMicroAccuracy.Location = new System.Drawing.Point(12, 126);
            this.txtMicroAccuracy.Name = "txtMicroAccuracy";
            this.txtMicroAccuracy.Size = new System.Drawing.Size(70, 23);
            this.txtMicroAccuracy.TabIndex = 8;
            // 
            // txtLogLoss
            // 
            this.txtLogLoss.Location = new System.Drawing.Point(12, 171);
            this.txtLogLoss.Name = "txtLogLoss";
            this.txtLogLoss.Size = new System.Drawing.Size(70, 23);
            this.txtLogLoss.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Test Ratio:";
            // 
            // txtTestRatio
            // 
            this.txtTestRatio.Location = new System.Drawing.Point(142, 19);
            this.txtTestRatio.Name = "txtTestRatio";
            this.txtTestRatio.Size = new System.Drawing.Size(36, 23);
            this.txtTestRatio.TabIndex = 3;
            this.txtTestRatio.Text = "0.2";
            // 
            // lblEvaluateModelStatus
            // 
            this.lblEvaluateModelStatus.AutoSize = true;
            this.lblEvaluateModelStatus.Location = new System.Drawing.Point(163, 171);
            this.lblEvaluateModelStatus.Name = "lblEvaluateModelStatus";
            this.lblEvaluateModelStatus.Size = new System.Drawing.Size(0, 15);
            this.lblEvaluateModelStatus.TabIndex = 18;
            // 
            // lblSaveModelStatus
            // 
            this.lblSaveModelStatus.AutoSize = true;
            this.lblSaveModelStatus.Location = new System.Drawing.Point(140, 359);
            this.lblSaveModelStatus.Name = "lblSaveModelStatus";
            this.lblSaveModelStatus.Size = new System.Drawing.Size(0, 15);
            this.lblSaveModelStatus.TabIndex = 18;
            // 
            // cboModel
            // 
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(155, 36);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(232, 23);
            this.cboModel.TabIndex = 19;
            // 
            // lblBlameProbability
            // 
            this.lblBlameProbability.AutoSize = true;
            this.lblBlameProbability.ForeColor = System.Drawing.Color.Red;
            this.lblBlameProbability.Location = new System.Drawing.Point(159, 174);
            this.lblBlameProbability.Name = "lblBlameProbability";
            this.lblBlameProbability.Size = new System.Drawing.Size(0, 15);
            this.lblBlameProbability.TabIndex = 20;
            // 
            // lblNeutralProbability
            // 
            this.lblNeutralProbability.AutoSize = true;
            this.lblNeutralProbability.Location = new System.Drawing.Point(238, 175);
            this.lblNeutralProbability.Name = "lblNeutralProbability";
            this.lblNeutralProbability.Size = new System.Drawing.Size(0, 15);
            this.lblNeutralProbability.TabIndex = 20;
            // 
            // lblComplimentProbability
            // 
            this.lblComplimentProbability.AutoSize = true;
            this.lblComplimentProbability.ForeColor = System.Drawing.Color.Blue;
            this.lblComplimentProbability.Location = new System.Drawing.Point(321, 174);
            this.lblComplimentProbability.Name = "lblComplimentProbability";
            this.lblComplimentProbability.Size = new System.Drawing.Size(0, 15);
            this.lblComplimentProbability.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(165, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Blame";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(312, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Compliment";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(237, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 15);
            this.label18.TabIndex = 22;
            this.label18.Text = "Neutral";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Dataset for train-test set|*.json";
            // 
            // lblLoadModelStatus
            // 
            this.lblLoadModelStatus.AutoSize = true;
            this.lblLoadModelStatus.Location = new System.Drawing.Point(153, 66);
            this.lblLoadModelStatus.Name = "lblLoadModelStatus";
            this.lblLoadModelStatus.Size = new System.Drawing.Size(0, 15);
            this.lblLoadModelStatus.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel12);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtMacroAccuracy);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblRecall2);
            this.groupBox1.Controls.Add(this.lblRecall1);
            this.groupBox1.Controls.Add(this.lblRecall0);
            this.groupBox1.Controls.Add(this.lblPrecision2);
            this.groupBox1.Controls.Add(this.lblCount22);
            this.groupBox1.Controls.Add(this.lblCount12);
            this.groupBox1.Controls.Add(this.lblCount02);
            this.groupBox1.Controls.Add(this.lblPrecision1);
            this.groupBox1.Controls.Add(this.lblCount21);
            this.groupBox1.Controls.Add(this.lblCount11);
            this.groupBox1.Controls.Add(this.lblCount01);
            this.groupBox1.Controls.Add(this.lblPrecision0);
            this.groupBox1.Controls.Add(this.lblCount20);
            this.groupBox1.Controls.Add(this.lblCount10);
            this.groupBox1.Controls.Add(this.lblCount00);
            this.groupBox1.Controls.Add(this.lblConfusionTable);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLogLoss);
            this.groupBox1.Controls.Add(this.txtMicroAccuracy);
            this.groupBox1.Controls.Add(this.btnEvaluateModel);
            this.groupBox1.Location = new System.Drawing.Point(3, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 202);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model quality metrics evaluation:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(408, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 140);
            this.panel8.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(354, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 140);
            this.panel7.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(310, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 140);
            this.panel6.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(264, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 140);
            this.panel5.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(214, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 140);
            this.panel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(129, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 140);
            this.panel2.TabIndex = 9;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(129, 195);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(280, 1);
            this.panel12.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(129, 169);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(280, 1);
            this.panel11.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(129, 140);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(280, 1);
            this.panel10.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(129, 112);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 1);
            this.panel9.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(129, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 1);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(129, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Green;
            this.label20.Location = new System.Drawing.Point(132, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 15);
            this.label20.TabIndex = 6;
            this.label20.Text = "Precision";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "2. Blame";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "1. Neutral";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(360, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Recall";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "0. Compliment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "0";
            // 
            // lblRecall2
            // 
            this.lblRecall2.AutoSize = true;
            this.lblRecall2.ForeColor = System.Drawing.Color.Blue;
            this.lblRecall2.Location = new System.Drawing.Point(361, 148);
            this.lblRecall2.Name = "lblRecall2";
            this.lblRecall2.Size = new System.Drawing.Size(40, 15);
            this.lblRecall2.TabIndex = 6;
            this.lblRecall2.Text = "0.9090";
            // 
            // lblRecall1
            // 
            this.lblRecall1.AutoSize = true;
            this.lblRecall1.ForeColor = System.Drawing.Color.Blue;
            this.lblRecall1.Location = new System.Drawing.Point(360, 119);
            this.lblRecall1.Name = "lblRecall1";
            this.lblRecall1.Size = new System.Drawing.Size(40, 15);
            this.lblRecall1.TabIndex = 6;
            this.lblRecall1.Text = "0.9090";
            // 
            // lblRecall0
            // 
            this.lblRecall0.AutoSize = true;
            this.lblRecall0.ForeColor = System.Drawing.Color.Blue;
            this.lblRecall0.Location = new System.Drawing.Point(359, 91);
            this.lblRecall0.Name = "lblRecall0";
            this.lblRecall0.Size = new System.Drawing.Size(40, 15);
            this.lblRecall0.TabIndex = 6;
            this.lblRecall0.Text = "0.9090";
            // 
            // lblPrecision2
            // 
            this.lblPrecision2.AutoSize = true;
            this.lblPrecision2.ForeColor = System.Drawing.Color.Green;
            this.lblPrecision2.Location = new System.Drawing.Point(315, 175);
            this.lblPrecision2.Name = "lblPrecision2";
            this.lblPrecision2.Size = new System.Drawing.Size(34, 15);
            this.lblPrecision2.TabIndex = 6;
            this.lblPrecision2.Text = "1,248";
            // 
            // lblCount22
            // 
            this.lblCount22.AutoSize = true;
            this.lblCount22.Location = new System.Drawing.Point(315, 148);
            this.lblCount22.Name = "lblCount22";
            this.lblCount22.Size = new System.Drawing.Size(34, 15);
            this.lblCount22.TabIndex = 6;
            this.lblCount22.Text = "1,248";
            // 
            // lblCount12
            // 
            this.lblCount12.AutoSize = true;
            this.lblCount12.Location = new System.Drawing.Point(316, 119);
            this.lblCount12.Name = "lblCount12";
            this.lblCount12.Size = new System.Drawing.Size(34, 15);
            this.lblCount12.TabIndex = 6;
            this.lblCount12.Text = "1,248";
            // 
            // lblCount02
            // 
            this.lblCount02.AutoSize = true;
            this.lblCount02.Location = new System.Drawing.Point(317, 91);
            this.lblCount02.Name = "lblCount02";
            this.lblCount02.Size = new System.Drawing.Size(34, 15);
            this.lblCount02.TabIndex = 6;
            this.lblCount02.Text = "1,248";
            // 
            // lblPrecision1
            // 
            this.lblPrecision1.AutoSize = true;
            this.lblPrecision1.ForeColor = System.Drawing.Color.Green;
            this.lblPrecision1.Location = new System.Drawing.Point(270, 175);
            this.lblPrecision1.Name = "lblPrecision1";
            this.lblPrecision1.Size = new System.Drawing.Size(34, 15);
            this.lblPrecision1.TabIndex = 6;
            this.lblPrecision1.Text = "1,248";
            // 
            // lblCount21
            // 
            this.lblCount21.AutoSize = true;
            this.lblCount21.Location = new System.Drawing.Point(270, 148);
            this.lblCount21.Name = "lblCount21";
            this.lblCount21.Size = new System.Drawing.Size(34, 15);
            this.lblCount21.TabIndex = 6;
            this.lblCount21.Text = "1,248";
            // 
            // lblCount11
            // 
            this.lblCount11.AutoSize = true;
            this.lblCount11.Location = new System.Drawing.Point(271, 119);
            this.lblCount11.Name = "lblCount11";
            this.lblCount11.Size = new System.Drawing.Size(34, 15);
            this.lblCount11.TabIndex = 6;
            this.lblCount11.Text = "1,248";
            // 
            // lblCount01
            // 
            this.lblCount01.AutoSize = true;
            this.lblCount01.Location = new System.Drawing.Point(270, 91);
            this.lblCount01.Name = "lblCount01";
            this.lblCount01.Size = new System.Drawing.Size(34, 15);
            this.lblCount01.TabIndex = 6;
            this.lblCount01.Text = "1,248";
            // 
            // lblPrecision0
            // 
            this.lblPrecision0.AutoSize = true;
            this.lblPrecision0.ForeColor = System.Drawing.Color.Green;
            this.lblPrecision0.Location = new System.Drawing.Point(221, 175);
            this.lblPrecision0.Name = "lblPrecision0";
            this.lblPrecision0.Size = new System.Drawing.Size(34, 15);
            this.lblPrecision0.TabIndex = 6;
            this.lblPrecision0.Text = "1,248";
            // 
            // lblCount20
            // 
            this.lblCount20.AutoSize = true;
            this.lblCount20.Location = new System.Drawing.Point(221, 148);
            this.lblCount20.Name = "lblCount20";
            this.lblCount20.Size = new System.Drawing.Size(34, 15);
            this.lblCount20.TabIndex = 6;
            this.lblCount20.Text = "1,248";
            // 
            // lblCount10
            // 
            this.lblCount10.AutoSize = true;
            this.lblCount10.Location = new System.Drawing.Point(220, 119);
            this.lblCount10.Name = "lblCount10";
            this.lblCount10.Size = new System.Drawing.Size(34, 15);
            this.lblCount10.TabIndex = 6;
            this.lblCount10.Text = "1,248";
            // 
            // lblCount00
            // 
            this.lblCount00.AutoSize = true;
            this.lblCount00.Location = new System.Drawing.Point(220, 91);
            this.lblCount00.Name = "lblCount00";
            this.lblCount00.Size = new System.Drawing.Size(34, 15);
            this.lblCount00.TabIndex = 6;
            this.lblCount00.Text = "1,248";
            // 
            // lblConfusionTable
            // 
            this.lblConfusionTable.AutoSize = true;
            this.lblConfusionTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfusionTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfusionTable.ForeColor = System.Drawing.Color.Blue;
            this.lblConfusionTable.Location = new System.Drawing.Point(222, 36);
            this.lblConfusionTable.Name = "lblConfusionTable";
            this.lblConfusionTable.Size = new System.Drawing.Size(96, 15);
            this.lblConfusionTable.TabIndex = 6;
            this.lblConfusionTable.Text = "Confusion table:";
            this.lblConfusionTable.Click += new System.EventHandler(this.lblConfusionTable_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(128, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 15);
            this.label21.TabIndex = 6;
            this.label21.Text = "Predicted Truth";
            // 
            // picVoice
            // 
            this.picVoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVoice.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_voice;
            this.picVoice.Location = new System.Drawing.Point(390, 84);
            this.picVoice.Name = "picVoice";
            this.picVoice.Size = new System.Drawing.Size(25, 27);
            this.picVoice.TabIndex = 25;
            this.picVoice.TabStop = false;
            this.picVoice.Click += new System.EventHandler(this.picVoice_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(41, 19);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(36, 23);
            this.txtSeed.TabIndex = 3;
            this.txtSeed.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Seed:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radOVA);
            this.groupBox2.Controls.Add(this.radSDCA);
            this.groupBox2.Controls.Add(this.btnLoadData);
            this.groupBox2.Controls.Add(this.txtTestRatio);
            this.groupBox2.Controls.Add(this.txtSeed);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnBuildModel);
            this.groupBox2.Controls.Add(this.lblTrainStatus);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 135);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Train Model";
            // 
            // radOVA
            // 
            this.radOVA.AutoSize = true;
            this.radOVA.Location = new System.Drawing.Point(40, 78);
            this.radOVA.Name = "radOVA";
            this.radOVA.Size = new System.Drawing.Size(232, 19);
            this.radOVA.TabIndex = 4;
            this.radOVA.Text = "OVA (One-Versus-All) Multiclass Trainer";
            this.radOVA.UseVisualStyleBackColor = true;
            // 
            // radSDCA
            // 
            this.radSDCA.AutoSize = true;
            this.radSDCA.Checked = true;
            this.radSDCA.Location = new System.Drawing.Point(40, 53);
            this.radSDCA.Name = "radSDCA";
            this.radSDCA.Size = new System.Drawing.Size(301, 19);
            this.radSDCA.TabIndex = 4;
            this.radSDCA.TabStop = true;
            this.radSDCA.Text = "Stochastic Dual Coordinate Ascent Multiclass Trainer";
            this.radSDCA.UseVisualStyleBackColor = true;
            // 
            // lblTrainStatus
            // 
            this.lblTrainStatus.AutoSize = true;
            this.lblTrainStatus.Location = new System.Drawing.Point(198, 107);
            this.lblTrainStatus.Name = "lblTrainStatus";
            this.lblTrainStatus.Size = new System.Drawing.Size(0, 15);
            this.lblTrainStatus.TabIndex = 6;
            // 
            // lblProbabilityClassify
            // 
            this.lblProbabilityClassify.AutoSize = true;
            this.lblProbabilityClassify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProbabilityClassify.Location = new System.Drawing.Point(66, 174);
            this.lblProbabilityClassify.Name = "lblProbabilityClassify";
            this.lblProbabilityClassify.Size = new System.Drawing.Size(67, 15);
            this.lblProbabilityClassify.TabIndex = 20;
            this.lblProbabilityClassify.Text = "Probability:";
            this.lblProbabilityClassify.Click += new System.EventHandler(this.lblProbabilityClassify_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadModel);
            this.groupBox3.Controls.Add(this.btnPredict);
            this.groupBox3.Controls.Add(this.picVoice);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtInputData);
            this.groupBox3.Controls.Add(this.lblLoadModelStatus);
            this.groupBox3.Controls.Add(this.picBlame);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.picNeutral);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.picCompliment);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cboModel);
            this.groupBox3.Controls.Add(this.lblComplimentProbability);
            this.groupBox3.Controls.Add(this.lblBlameProbability);
            this.groupBox3.Controls.Add(this.lblProbabilityClassify);
            this.groupBox3.Controls.Add(this.lblNeutralProbability);
            this.groupBox3.Location = new System.Drawing.Point(6, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 205);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Use Model";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSaveModelStatus);
            this.Controls.Add(this.lblEvaluateModelStatus);
            this.Controls.Add(this.btnSaveModel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ML.Emotion - KMOU - Data Science Lab - 407";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBlame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNeutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompliment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPredict;
        private Label label1;
        private TextBox txtInputData;
        private Button btnLoadData;
        private Button btnBuildModel;
        private Button btnEvaluateModel;
        private Button btnSaveModel;
        private Button btnLoadModel;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox picBlame;
        private PictureBox picNeutral;
        private PictureBox picCompliment;
        private TextBox txtMacroAccuracy;
        private TextBox txtMicroAccuracy;
        private TextBox txtLogLoss;
        private Label label12;
        private TextBox txtTestRatio;
        private Label lblEvaluateModelStatus;
        private Label lblSaveModelStatus;
        private ComboBox cboModel;
        private Label lblBlameProbability;
        private Label lblNeutralProbability;
        private Label lblComplimentProbability;
        private Label label16;
        private Label label17;
        private Label label18;
        private OpenFileDialog openFileDialog1;
        private Label lblLoadModelStatus;
        private GroupBox groupBox1;
        private PictureBox picVoice;
        private TextBox txtSeed;
        private Label label13;
        private GroupBox groupBox2;
        private RadioButton radSDCA;
        private RadioButton radOVA;
        private Panel panel1;
        private Panel panel2;
        private Label lblConfusionTable;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private Panel panel4;
        private Label label9;
        private Label lblCount00;
        private Panel panel6;
        private Panel panel5;
        private Label label11;
        private Panel panel7;
        private Label label14;
        private Label label15;
        private Label lblRecall0;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Label label20;
        private Label label21;
        private Label lblPrecision2;
        private Label lblCount22;
        private Label lblCount12;
        private Label lblCount02;
        private Label lblPrecision1;
        private Label lblCount21;
        private Label lblCount11;
        private Label lblCount01;
        private Label lblPrecision0;
        private Label lblCount20;
        private Label lblCount10;
        private Label lblRecall2;
        private Label lblRecall1;
        private Label lblTrainStatus;
        private Label lblProbabilityClassify;
        private GroupBox groupBox3;
    }
}