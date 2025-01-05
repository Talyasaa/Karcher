using System;

namespace Noam
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblConnected = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHamburger = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblPartReplacement = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lblSelectPart = new System.Windows.Forms.Label();
            this.cmbSelectPart = new System.Windows.Forms.ComboBox();
            this.lblFaultType = new System.Windows.Forms.Label();
            this.cmbFaultType = new System.Windows.Forms.ComboBox();
            this.btnFaultDetection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.ForeColor = System.Drawing.Color.Green;
            this.lblConnected.Location = new System.Drawing.Point(12, 366);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(59, 13);
            this.lblConnected.TabIndex = 0;
            this.lblConnected.Text = "Connected";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(528, 356);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 32);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "🏠 Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHamburger
            // 
            this.btnHamburger.Location = new System.Drawing.Point(558, 8);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(30, 32);
            this.btnHamburger.TabIndex = 2;
            this.btnHamburger.Text = "☰";
            this.btnHamburger.UseVisualStyleBackColor = true;
            this.btnHamburger.Click += new System.EventHandler(this.btnHamburger_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(134, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(150, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 26);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Repair Management - Receiving a Quote";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(50, 150);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "Product Name:";
            // 
            // cmbProductName
            // 
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Items.AddRange(new object[] {
            "Vacuum Cleaner Model X",
            "Vacuum Cleaner Model Y",
            "Vacuum Cleaner Model Z",
            "Vacuum Cleaner Model A",
            "Vacuum Cleaner Model B",
            "Vacuum Cleaner Model C",
            "Vacuum Cleaner Model D",
            "Vacuum Cleaner Model E",
            "Vacuum Cleaner Model F"});
            this.cmbProductName.Location = new System.Drawing.Point(200, 145);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(300, 21);
            this.cmbProductName.TabIndex = 12;
            // 
            // lblPartReplacement
            // 
            this.lblPartReplacement.AutoSize = true;
            this.lblPartReplacement.Location = new System.Drawing.Point(50, 200);
            this.lblPartReplacement.Name = "lblPartReplacement";
            this.lblPartReplacement.Size = new System.Drawing.Size(95, 13);
            this.lblPartReplacement.TabIndex = 13;
            this.lblPartReplacement.Text = "Part Replacement:";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(200, 195);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 14;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.PartReplacementChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(270, 195);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 15;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.PartReplacementChanged);
            // 
            // lblSelectPart
            // 
            this.lblSelectPart.AutoSize = true;
            this.lblSelectPart.Location = new System.Drawing.Point(50, 250);
            this.lblSelectPart.Name = "lblSelectPart";
            this.lblSelectPart.Size = new System.Drawing.Size(71, 13);
            this.lblSelectPart.TabIndex = 16;
            this.lblSelectPart.Text = "Select a Part:";
            this.lblSelectPart.Visible = false;
            // 
            // cmbSelectPart
            // 
            this.cmbSelectPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectPart.FormattingEnabled = true;
            this.cmbSelectPart.Items.AddRange(new object[] {
            "Motor",
            "Dust Bag",
            "Filter",
            "Hose",
            "Brush",
            "Battery",
            "Wheels",
            "Handle",
            "Power Cord",
            "Nozzle"});
            this.cmbSelectPart.Location = new System.Drawing.Point(200, 245);
            this.cmbSelectPart.Name = "cmbSelectPart";
            this.cmbSelectPart.Size = new System.Drawing.Size(300, 21);
            this.cmbSelectPart.TabIndex = 17;
            this.cmbSelectPart.Visible = false;
            // 
            // lblFaultType
            // 
            this.lblFaultType.AutoSize = true;
            this.lblFaultType.Location = new System.Drawing.Point(50, 300);
            this.lblFaultType.Name = "lblFaultType";
            this.lblFaultType.Size = new System.Drawing.Size(60, 13);
            this.lblFaultType.TabIndex = 18;
            this.lblFaultType.Text = "Fault Type:";
            this.lblFaultType.Visible = false;
            // 
            // cmbFaultType
            // 
            this.cmbFaultType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaultType.FormattingEnabled = true;
            this.cmbFaultType.Items.AddRange(new object[] {
            "Overheating",
            "No Suction",
            "Strange Noise",
            "Does Not Start",
            "Low Battery",
            "Brush Not Rotating",
            "Power Issue",
            "Filter Clogged",
            "Dust Bag Full",
            "Fault Detection"});
            this.cmbFaultType.Location = new System.Drawing.Point(200, 295);
            this.cmbFaultType.Name = "cmbFaultType";
            this.cmbFaultType.Size = new System.Drawing.Size(300, 21);
            this.cmbFaultType.TabIndex = 19;
            this.cmbFaultType.Visible = false;
            // 
            // btnFaultDetection
            // 
            this.btnFaultDetection.Location = new System.Drawing.Point(200, 340);
            this.btnFaultDetection.Name = "btnFaultDetection";
            this.btnFaultDetection.Size = new System.Drawing.Size(150, 30);
            this.btnFaultDetection.TabIndex = 20;
            this.btnFaultDetection.Text = "Fault Detection";
            this.btnFaultDetection.UseVisualStyleBackColor = true;
            this.btnFaultDetection.Click += new System.EventHandler(this.btnFaultDetection_Click);
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnFaultDetection);
            this.Controls.Add(this.cmbFaultType);
            this.Controls.Add(this.lblFaultType);
            this.Controls.Add(this.cmbSelectPart);
            this.Controls.Add(this.lblSelectPart);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.lblPartReplacement);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHamburger);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblConnected);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHamburger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label lblPartReplacement;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lblSelectPart;
        private System.Windows.Forms.ComboBox cmbSelectPart;
        private System.Windows.Forms.Label lblFaultType;
        private System.Windows.Forms.ComboBox cmbFaultType;
        private System.Windows.Forms.Button btnFaultDetection;
    }
}
