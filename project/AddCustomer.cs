
using System;
using System.Windows.Forms;

namespace Noam
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(); // יצירת אינסטנס של MainPage
            mainPage.Show(); // פתיחת הפורם
            this.Hide(); // הסתרת הפורם הנוכחי
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
