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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picBlame = new System.Windows.Forms.PictureBox();
            this.picNeutral = new System.Windows.Forms.PictureBox();
            this.picCompliment = new System.Windows.Forms.PictureBox();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.txtAUC_PR = new System.Windows.Forms.TextBox();
            this.txtAUC_ROC = new System.Windows.Forms.TextBox();
            this.txtF1Score = new System.Windows.Forms.TextBox();
            this.txtLogLoss = new System.Windows.Forms.TextBox();
            this.txtLogLossReduction = new System.Windows.Forms.TextBox();
            this.txtNegativePrecision = new System.Windows.Forms.TextBox();
            this.txtNegativeRecall = new System.Windows.Forms.TextBox();
            this.txtPositivePrecision = new System.Windows.Forms.TextBox();
            this.txtPositiveRecall = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTestRatio = new System.Windows.Forms.TextBox();
            this.lblBuildModelStatus = new System.Windows.Forms.Label();
            this.lblEvaluateModelStatus = new System.Windows.Forms.Label();
            this.lblSaveModelStatus = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.lblBlameProbability = new System.Windows.Forms.Label();
            this.picBlameArrow = new System.Windows.Forms.PictureBox();
            this.lblNeutralProbability = new System.Windows.Forms.Label();
            this.picNeutralArrow = new System.Windows.Forms.PictureBox();
            this.lblComplimentProbability = new System.Windows.Forms.Label();
            this.picComplimentArrow = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblLoadModelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBlame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNeutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompliment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlameArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNeutralArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComplimentArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(25, 530);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(123, 23);
            this.btnPredict.TabIndex = 16;
            this.btnPredict.Text = "Predict Emotion";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(69, 488);
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(320, 23);
            this.txtInputData.TabIndex = 15;
            this.txtInputData.Text = "This was a horrible meal";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(18, 11);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(132, 23);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnBuildModel
            // 
            this.btnBuildModel.Location = new System.Drawing.Point(18, 44);
            this.btnBuildModel.Name = "btnBuildModel";
            this.btnBuildModel.Size = new System.Drawing.Size(132, 23);
            this.btnBuildModel.TabIndex = 1;
            this.btnBuildModel.Text = "Build Model";
            this.btnBuildModel.UseVisualStyleBackColor = true;
            this.btnBuildModel.Click += new System.EventHandler(this.btnBuildModel_Click);
            // 
            // btnEvaluateModel
            // 
            this.btnEvaluateModel.Location = new System.Drawing.Point(18, 78);
            this.btnEvaluateModel.Name = "btnEvaluateModel";
            this.btnEvaluateModel.Size = new System.Drawing.Size(132, 23);
            this.btnEvaluateModel.TabIndex = 2;
            this.btnEvaluateModel.Text = "Evaluate Model";
            this.btnEvaluateModel.UseVisualStyleBackColor = true;
            this.btnEvaluateModel.Click += new System.EventHandler(this.btnEvaluateModel_Click);
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Location = new System.Drawing.Point(23, 409);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(127, 23);
            this.btnSaveModel.TabIndex = 13;
            this.btnSaveModel.Text = "Save Model";
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Location = new System.Drawing.Point(24, 439);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(124, 23);
            this.btnLoadModel.TabIndex = 14;
            this.btnLoadModel.Text = "Load Model";
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Accuracy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "AreaUnderPrecisionRecallCurve(AUC_PR):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "AreaUnderRocCurve(AUC_ROC):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "F1Score: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "LogLoss: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "LogLossReduction:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "NegativePrecision :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "NegativeRecall :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "PositivePrecision: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "PositiveRecall: ";
            // 
            // picBlame
            // 
            this.picBlame.Image = global::ML.EmotionDemo.Properties.Resources.ic_angry;
            this.picBlame.Location = new System.Drawing.Point(166, 532);
            this.picBlame.Name = "picBlame";
            this.picBlame.Size = new System.Drawing.Size(33, 35);
            this.picBlame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlame.TabIndex = 7;
            this.picBlame.TabStop = false;
            // 
            // picNeutral
            // 
            this.picNeutral.Image = global::ML.EmotionDemo.Properties.Resources.ic_neutral;
            this.picNeutral.Location = new System.Drawing.Point(246, 532);
            this.picNeutral.Name = "picNeutral";
            this.picNeutral.Size = new System.Drawing.Size(33, 35);
            this.picNeutral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNeutral.TabIndex = 7;
            this.picNeutral.TabStop = false;
            // 
            // picCompliment
            // 
            this.picCompliment.Image = global::ML.EmotionDemo.Properties.Resources.ic_love;
            this.picCompliment.Location = new System.Drawing.Point(328, 532);
            this.picCompliment.Name = "picCompliment";
            this.picCompliment.Size = new System.Drawing.Size(33, 35);
            this.picCompliment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompliment.TabIndex = 7;
            this.picCompliment.TabStop = false;
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(88, 113);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(301, 23);
            this.txtAccuracy.TabIndex = 3;
            // 
            // txtAUC_PR
            // 
            this.txtAUC_PR.Location = new System.Drawing.Point(246, 145);
            this.txtAUC_PR.Name = "txtAUC_PR";
            this.txtAUC_PR.Size = new System.Drawing.Size(143, 23);
            this.txtAUC_PR.TabIndex = 4;
            // 
            // txtAUC_ROC
            // 
            this.txtAUC_ROC.Location = new System.Drawing.Point(207, 173);
            this.txtAUC_ROC.Name = "txtAUC_ROC";
            this.txtAUC_ROC.Size = new System.Drawing.Size(182, 23);
            this.txtAUC_ROC.TabIndex = 5;
            // 
            // txtF1Score
            // 
            this.txtF1Score.Location = new System.Drawing.Point(88, 200);
            this.txtF1Score.Name = "txtF1Score";
            this.txtF1Score.Size = new System.Drawing.Size(301, 23);
            this.txtF1Score.TabIndex = 6;
            // 
            // txtLogLoss
            // 
            this.txtLogLoss.Location = new System.Drawing.Point(88, 229);
            this.txtLogLoss.Name = "txtLogLoss";
            this.txtLogLoss.Size = new System.Drawing.Size(301, 23);
            this.txtLogLoss.TabIndex = 7;
            // 
            // txtLogLossReduction
            // 
            this.txtLogLossReduction.Location = new System.Drawing.Point(131, 257);
            this.txtLogLossReduction.Name = "txtLogLossReduction";
            this.txtLogLossReduction.Size = new System.Drawing.Size(258, 23);
            this.txtLogLossReduction.TabIndex = 8;
            // 
            // txtNegativePrecision
            // 
            this.txtNegativePrecision.Location = new System.Drawing.Point(131, 286);
            this.txtNegativePrecision.Name = "txtNegativePrecision";
            this.txtNegativePrecision.Size = new System.Drawing.Size(258, 23);
            this.txtNegativePrecision.TabIndex = 9;
            // 
            // txtNegativeRecall
            // 
            this.txtNegativeRecall.Location = new System.Drawing.Point(131, 319);
            this.txtNegativeRecall.Name = "txtNegativeRecall";
            this.txtNegativeRecall.Size = new System.Drawing.Size(258, 23);
            this.txtNegativeRecall.TabIndex = 10;
            // 
            // txtPositivePrecision
            // 
            this.txtPositivePrecision.Location = new System.Drawing.Point(131, 348);
            this.txtPositivePrecision.Name = "txtPositivePrecision";
            this.txtPositivePrecision.Size = new System.Drawing.Size(258, 23);
            this.txtPositivePrecision.TabIndex = 11;
            // 
            // txtPositiveRecall
            // 
            this.txtPositiveRecall.Location = new System.Drawing.Point(131, 376);
            this.txtPositiveRecall.Name = "txtPositiveRecall";
            this.txtPositiveRecall.Size = new System.Drawing.Size(258, 23);
            this.txtPositiveRecall.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Test Ratio:";
            // 
            // txtTestRatio
            // 
            this.txtTestRatio.Location = new System.Drawing.Point(230, 11);
            this.txtTestRatio.Name = "txtTestRatio";
            this.txtTestRatio.Size = new System.Drawing.Size(159, 23);
            this.txtTestRatio.TabIndex = 3;
            this.txtTestRatio.Text = "0.2";
            // 
            // lblBuildModelStatus
            // 
            this.lblBuildModelStatus.AutoSize = true;
            this.lblBuildModelStatus.Location = new System.Drawing.Point(166, 49);
            this.lblBuildModelStatus.Name = "lblBuildModelStatus";
            this.lblBuildModelStatus.Size = new System.Drawing.Size(0, 15);
            this.lblBuildModelStatus.TabIndex = 18;
            // 
            // lblEvaluateModelStatus
            // 
            this.lblEvaluateModelStatus.AutoSize = true;
            this.lblEvaluateModelStatus.Location = new System.Drawing.Point(166, 82);
            this.lblEvaluateModelStatus.Name = "lblEvaluateModelStatus";
            this.lblEvaluateModelStatus.Size = new System.Drawing.Size(0, 15);
            this.lblEvaluateModelStatus.TabIndex = 18;
            // 
            // lblSaveModelStatus
            // 
            this.lblSaveModelStatus.AutoSize = true;
            this.lblSaveModelStatus.Location = new System.Drawing.Point(157, 413);
            this.lblSaveModelStatus.Name = "lblSaveModelStatus";
            this.lblSaveModelStatus.Size = new System.Drawing.Size(0, 15);
            this.lblSaveModelStatus.TabIndex = 18;
            // 
            // cboModel
            // 
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(157, 441);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(232, 23);
            this.cboModel.TabIndex = 19;
            // 
            // lblBlameProbability
            // 
            this.lblBlameProbability.AutoSize = true;
            this.lblBlameProbability.Location = new System.Drawing.Point(139, 605);
            this.lblBlameProbability.Name = "lblBlameProbability";
            this.lblBlameProbability.Size = new System.Drawing.Size(89, 15);
            this.lblBlameProbability.TabIndex = 20;
            this.lblBlameProbability.Text = "Probability 10%";
            this.lblBlameProbability.Visible = false;
            // 
            // picBlameArrow
            // 
            this.picBlameArrow.Image = global::ML.EmotionDemo.Properties.Resources.ic_arrow;
            this.picBlameArrow.Location = new System.Drawing.Point(169, 573);
            this.picBlameArrow.Name = "picBlameArrow";
            this.picBlameArrow.Size = new System.Drawing.Size(23, 25);
            this.picBlameArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlameArrow.TabIndex = 21;
            this.picBlameArrow.TabStop = false;
            this.picBlameArrow.Visible = false;
            // 
            // lblNeutralProbability
            // 
            this.lblNeutralProbability.AutoSize = true;
            this.lblNeutralProbability.Location = new System.Drawing.Point(226, 605);
            this.lblNeutralProbability.Name = "lblNeutralProbability";
            this.lblNeutralProbability.Size = new System.Drawing.Size(89, 15);
            this.lblNeutralProbability.TabIndex = 20;
            this.lblNeutralProbability.Text = "Probability 10%";
            this.lblNeutralProbability.Visible = false;
            // 
            // picNeutralArrow
            // 
            this.picNeutralArrow.Image = global::ML.EmotionDemo.Properties.Resources.ic_arrow;
            this.picNeutralArrow.Location = new System.Drawing.Point(252, 573);
            this.picNeutralArrow.Name = "picNeutralArrow";
            this.picNeutralArrow.Size = new System.Drawing.Size(23, 25);
            this.picNeutralArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNeutralArrow.TabIndex = 21;
            this.picNeutralArrow.TabStop = false;
            this.picNeutralArrow.Visible = false;
            // 
            // lblComplimentProbability
            // 
            this.lblComplimentProbability.AutoSize = true;
            this.lblComplimentProbability.Location = new System.Drawing.Point(303, 605);
            this.lblComplimentProbability.Name = "lblComplimentProbability";
            this.lblComplimentProbability.Size = new System.Drawing.Size(89, 15);
            this.lblComplimentProbability.TabIndex = 20;
            this.lblComplimentProbability.Text = "Probability 10%";
            this.lblComplimentProbability.Visible = false;
            // 
            // picComplimentArrow
            // 
            this.picComplimentArrow.Image = global::ML.EmotionDemo.Properties.Resources.ic_arrow;
            this.picComplimentArrow.Location = new System.Drawing.Point(333, 573);
            this.picComplimentArrow.Name = "picComplimentArrow";
            this.picComplimentArrow.Size = new System.Drawing.Size(23, 25);
            this.picComplimentArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComplimentArrow.TabIndex = 21;
            this.picComplimentArrow.TabStop = false;
            this.picComplimentArrow.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(167, 516);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Blame";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(314, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Compliment";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(239, 516);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 15);
            this.label18.TabIndex = 22;
            this.label18.Text = "Neutral";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Dataset for train-test set|*.txt";
            // 
            // lblLoadModelStatus
            // 
            this.lblLoadModelStatus.AutoSize = true;
            this.lblLoadModelStatus.Location = new System.Drawing.Point(155, 468);
            this.lblLoadModelStatus.Name = "lblLoadModelStatus";
            this.lblLoadModelStatus.Size = new System.Drawing.Size(0, 15);
            this.lblLoadModelStatus.TabIndex = 23;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 630);
            this.Controls.Add(this.lblLoadModelStatus);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.picComplimentArrow);
            this.Controls.Add(this.lblComplimentProbability);
            this.Controls.Add(this.picNeutralArrow);
            this.Controls.Add(this.lblNeutralProbability);
            this.Controls.Add(this.picBlameArrow);
            this.Controls.Add(this.lblBlameProbability);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.lblSaveModelStatus);
            this.Controls.Add(this.lblEvaluateModelStatus);
            this.Controls.Add(this.lblBuildModelStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAUC_ROC);
            this.Controls.Add(this.txtAUC_PR);
            this.Controls.Add(this.txtPositiveRecall);
            this.Controls.Add(this.txtPositivePrecision);
            this.Controls.Add(this.txtNegativeRecall);
            this.Controls.Add(this.txtNegativePrecision);
            this.Controls.Add(this.txtLogLossReduction);
            this.Controls.Add(this.txtLogLoss);
            this.Controls.Add(this.txtF1Score);
            this.Controls.Add(this.txtTestRatio);
            this.Controls.Add(this.txtAccuracy);
            this.Controls.Add(this.picCompliment);
            this.Controls.Add(this.picNeutral);
            this.Controls.Add(this.picBlame);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadModel);
            this.Controls.Add(this.btnSaveModel);
            this.Controls.Add(this.btnEvaluateModel);
            this.Controls.Add(this.btnBuildModel);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.txtInputData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPredict);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ML.Emotion - KMOU - Data Science Lab - 407";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBlame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNeutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompliment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlameArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNeutralArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComplimentArrow)).EndInit();
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox picBlame;
        private PictureBox picNeutral;
        private PictureBox picCompliment;
        private TextBox txtAccuracy;
        private TextBox txtAUC_PR;
        private TextBox txtAUC_ROC;
        private TextBox txtF1Score;
        private TextBox txtLogLoss;
        private TextBox txtLogLossReduction;
        private TextBox txtNegativePrecision;
        private TextBox txtNegativeRecall;
        private TextBox txtPositivePrecision;
        private TextBox txtPositiveRecall;
        private Label label12;
        private TextBox txtTestRatio;
        private Label lblBuildModelStatus;
        private Label lblEvaluateModelStatus;
        private Label lblSaveModelStatus;
        private ComboBox cboModel;
        private Label lblBlameProbability;
        private PictureBox picBlameArrow;
        private Label lblNeutralProbability;
        private PictureBox picNeutralArrow;
        private Label lblComplimentProbability;
        private PictureBox picComplimentArrow;
        private Label label16;
        private Label label17;
        private Label label18;
        private OpenFileDialog openFileDialog1;
        private Label lblLoadModelStatus;
    }
}