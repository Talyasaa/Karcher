using System;
using System.Drawing;
using System.Windows.Forms;

namespace Noam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btnHome_Click(object sender, EventArgs e) { }

        private void btnHamburger_Click(object sender, EventArgs e) { }

        private void btnForward_Click(object sender, EventArgs e) { }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            string employeeNumber = txtEmployeeNumber.Text;

            if (string.IsNullOrWhiteSpace(employeeName) || string.IsNullOrWhiteSpace(employeeNumber))
            {
                MessageBox.Show("Please enter both Employee Name and Employee Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Welcome, {employeeName}!", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


