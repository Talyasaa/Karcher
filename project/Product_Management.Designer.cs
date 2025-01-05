using System;

namespace Noam
{
    partial class Product_Management
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
        public void InitializeComponent()
        {
            this.lblConnected = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.ForeColor = System.Drawing.Color.Green;
            this.lblConnected.Location = new System.Drawing.Point(8, 341);
            this.lblConnected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(59, 13);
            this.lblConnected.TabIndex = 0;
            this.lblConnected.Text = "Connected";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(529, 323);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 117);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add New Product ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Product_Management";
            this.Text = "Product_Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage Product_Management = new MainPage();
            Product_Management.Show();
            this.Close();
        }




        private void btnSignIn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //private void Main_Load(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }

}
