
using System;
using System.Windows.Forms;

namespace Noam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // פעולות בעת טעינת הטופס
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home clicked.");
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu clicked.");
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forward clicked.");
        }
    }
}
