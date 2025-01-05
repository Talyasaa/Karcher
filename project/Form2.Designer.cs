

using System;

namespace Noam
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuoteForRepair = new System.Windows.Forms.Button();
            this.btnOpeningRepair = new System.Windows.Forms.Button();
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
            this.btnHome.Location = new System.Drawing.Point(529, 356);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 32);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "🏠 Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.lblTitle.Location = new System.Drawing.Point(230, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 26);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Repairs";
            // 
            // btnQuoteForRepair
            // 
            this.btnQuoteForRepair.Location = new System.Drawing.Point(200, 150);
            this.btnQuoteForRepair.Name = "btnQuoteForRepair";
            this.btnQuoteForRepair.Size = new System.Drawing.Size(150, 30);
            this.btnQuoteForRepair.TabIndex = 11;
            this.btnQuoteForRepair.Text = "Quote for Repair";
            this.btnQuoteForRepair.UseVisualStyleBackColor = true;
            this.btnQuoteForRepair.Click += new System.EventHandler(this.btnQuoteForRepair_Click);
            // 
            // btnOpeningRepair
            // 
            this.btnOpeningRepair.Location = new System.Drawing.Point(200, 200);
            this.btnOpeningRepair.Name = "btnOpeningRepair";
            this.btnOpeningRepair.Size = new System.Drawing.Size(150, 30);
            this.btnOpeningRepair.TabIndex = 12;
            this.btnOpeningRepair.Text = "Opening a Repair";
            this.btnOpeningRepair.UseVisualStyleBackColor = true;
            this.btnOpeningRepair.Click += new System.EventHandler(this.btnOpeningRepair_Click);
            // 
            // btnFaultDetection
            // 
            this.btnFaultDetection.Location = new System.Drawing.Point(200, 250);
            this.btnFaultDetection.Name = "btnFaultDetection";
            this.btnFaultDetection.Size = new System.Drawing.Size(150, 30);
            this.btnFaultDetection.TabIndex = 13;
            this.btnFaultDetection.Text = "Fault Detection";
            this.btnFaultDetection.UseVisualStyleBackColor = true;
            this.btnFaultDetection.Click += new System.EventHandler(this.btnFaultDetection_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnFaultDetection);
            this.Controls.Add(this.btnOpeningRepair);
            this.Controls.Add(this.btnQuoteForRepair);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.btnHome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuoteForRepair;
        private System.Windows.Forms.Button btnOpeningRepair;
        private System.Windows.Forms.Button btnFaultDetection;
    }
}

