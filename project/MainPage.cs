using System;
using System.Windows.Forms;

namespace Noam
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            Product_Management productManagement = new Product_Management();
            productManagement.Show();
            this.Hide();
        }

    }
}
