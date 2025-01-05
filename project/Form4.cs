
using System;
using System.Windows.Forms;

namespace Noam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void PartReplacementChanged(object sender, EventArgs e)
        {
            lblSelectPart.Visible = rbYes.Checked;
            cmbSelectPart.Visible = rbYes.Checked;

            lblFaultType.Visible = rbNo.Checked;
            cmbFaultType.Visible = rbNo.Checked;
        }

        private void btnFaultDetection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Fault Detection...");
        }
    }
}

