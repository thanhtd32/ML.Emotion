namespace ML.EmotionDemo
{
    partial class frmListClassify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListClassify));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvCustomer = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPredict = new System.Windows.Forms.Button();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtReview = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 251);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Customer:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 229);
            this.panel2.TabIndex = 0;
            // 
            // lvCustomer
            // 
            this.lvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCustomer.FullRowSelect = true;
            this.lvCustomer.GridLines = true;
            this.lvCustomer.Location = new System.Drawing.Point(0, 0);
            this.lvCustomer.Name = "lvCustomer";
            this.lvCustomer.Size = new System.Drawing.Size(200, 229);
            this.lvCustomer.TabIndex = 0;
            this.lvCustomer.UseCompatibleStateImageBehavior = false;
            this.lvCustomer.View = System.Windows.Forms.View.Details;
            this.lvCustomer.SelectedIndexChanged += new System.EventHandler(this.lvCustomer_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Customer ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer Name";
            this.columnHeader2.Width = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 183);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 183);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Of Reviews:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 161);
            this.panel4.TabIndex = 0;
            // 
            // lvProduct
            // 
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.GridLines = true;
            this.lvProduct.Location = new System.Drawing.Point(0, 0);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(328, 161);
            this.lvProduct.TabIndex = 0;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.SelectedIndexChanged += new System.EventHandler(this.lvProduct_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product ID";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product Name";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Emotion";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Probability";
            this.columnHeader6.Width = 70;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPredict);
            this.panel5.Controls.Add(this.cboModel);
            this.panel5.Controls.Add(this.btnLoadModel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 44);
            this.panel5.TabIndex = 3;
            // 
            // btnPredict
            // 
            this.btnPredict.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_prediction;
            this.btnPredict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPredict.Location = new System.Drawing.Point(378, 8);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(132, 30);
            this.btnPredict.TabIndex = 22;
            this.btnPredict.Text = "Predict Emotion";
            this.btnPredict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // cboModel
            // 
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(130, 12);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(232, 23);
            this.cboModel.TabIndex = 21;
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Image = global::ML.EmotionDemo_Multiclass.Properties.Resources.ic_openmodel;
            this.btnLoadModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadModel.Location = new System.Drawing.Point(12, 8);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(112, 30);
            this.btnLoadModel.TabIndex = 20;
            this.btnLoadModel.Text = "Choose Model";
            this.btnLoadModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(540, 251);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(206, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(334, 251);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtReview);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 183);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(334, 68);
            this.panel8.TabIndex = 3;
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(63, 2);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(262, 46);
            this.txtReview.TabIndex = 1;
            this.txtReview.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Review:";
            // 
            // frmListClassify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 295);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListClassify";
            this.Text = "ML.Emotion - KMOU - Data Science Lab - 407";
            this.Load += new System.EventHandler(this.frmListClassify_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private ListView lvCustomer;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private Panel panel4;
        private ListView lvProduct;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private ComboBox cboModel;
        private Button btnLoadModel;
        private Button btnPredict;
        private Panel panel8;
        private Label label1;
        private RichTextBox txtReview;
    }
}