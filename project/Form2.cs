using System.Windows.Forms;
using System;


using System.Windows.Forms;

namespace Noam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void btnQuoteForRepair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Quote for Repair...");
        }

        private void btnOpeningRepair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Opening a Repair...");
        }

        private void btnFaultDetection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Fault Detection...");
        }
    }
}
