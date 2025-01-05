using System;

namespace Noam
{
    partial class MainPage
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

        private void InitializeComponent()
        {
            this.lblConnected = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManageRepairs = new System.Windows.Forms.Button();
            this.btnCustomerService = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600); // הגדלת המסך
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // מיקום חלון במרכז המסך
            this.Name = "MainPage";
            this.Text = "MainPage";

            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.ForeColor = System.Drawing.Color.Green;
            this.lblConnected.Location = new System.Drawing.Point(10, 570);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(80, 20);
            this.lblConnected.TabIndex = 0;
            this.lblConnected.Text = "Connected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(250, 20); // מרכז המסך
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnManageRepairs
            // 
            this.btnManageRepairs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManageRepairs.Location = new System.Drawing.Point(300, 150);
            this.btnManageRepairs.Name = "btnManageRepairs";
            this.btnManageRepairs.Size = new System.Drawing.Size(200, 60);
            this.btnManageRepairs.TabIndex = 1;
            this.btnManageRepairs.Text = "Manage Repairs";
            this.btnManageRepairs.UseVisualStyleBackColor = true;
            this.btnManageRepairs.Click += new System.EventHandler(this.btnManageRepairs_Click);
            // 
            // btnCustomerService
            // 
            this.btnCustomerService.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerService.Location = new System.Drawing.Point(300, 240);
            this.btnCustomerService.Name = "btnCustomerService";
            this.btnCustomerService.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerService.TabIndex = 2;
            this.btnCustomerService.Text = "Customer Service";
            this.btnCustomerService.UseVisualStyleBackColor = true;
            this.btnCustomerService.Click += new System.EventHandler(this.btnCustomerService_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeManagement.Location = new System.Drawing.Point(300, 330);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(200, 60);
            this.btnEmployeeManagement.TabIndex = 3;
            this.btnEmployeeManagement.Text = "Employee Management";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(700, 550);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 30);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "🏠 Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MainPage Controls
            // 
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.btnCustomerService);
            this.Controls.Add(this.btnManageRepairs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConnected);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManageRepairs;
        private System.Windows.Forms.Button btnCustomerService;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnHome;

        // שיטה אחת בלבד שמטפלת בלחיצה על כפתור ה-Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            // הפעולה שתרצי לבצע כאשר לוחצים על כפתור Home
        }

        private void btnManageRepairs_Click(object sender, EventArgs e)
        {
            // Manage Repairs פעולה
        }

        private void btnCustomerService_Click(object sender, EventArgs e)
        {
            // Customer Service פעולה
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            // Employee Management פעולה
        }
    }
}
