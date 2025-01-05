using System;

namespace Noam
{
    partial class Form3
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
            this.lblPricePrompt = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
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
            this.lblTitle.Size = new System.Drawing.Size(156, 26);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Quote for Part";
            // 
            // lblPricePrompt
            // 
            this.lblPricePrompt.AutoSize = true;
            this.lblPricePrompt.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPricePrompt.Location = new System.Drawing.Point(100, 180);
            this.lblPricePrompt.Name = "lblPricePrompt";
            this.lblPricePrompt.Size = new System.Drawing.Size(185, 18);
            this.lblPricePrompt.TabIndex = 11;
            this.lblPricePrompt.Text = "The price for the repair is:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(310, 180);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPricePrompt);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.btnHome);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPricePrompt;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
