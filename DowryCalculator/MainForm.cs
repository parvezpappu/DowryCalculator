using System;
using System.Windows.Forms;

namespace DowryCalculator
{
    public partial class DowryWin : Form
    {
        public DowryWin()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void btnCgpa_Click(object sender, EventArgs e)
        {
        }


        // Open ProfileForm and hide main form
        private void btnProfile_Click(object sender, EventArgs e)
        {
            profileForm pf = new profileForm();
            this.Hide();  // Hide the current form (DowryWin)

            // Show ProfileForm
            pf.Show();

            // Subscribe to the FormClosed event so when ProfileForm closes, DowryWin will show again
            pf.FormClosed += (s, args) => this.Show();
        }

        // Open ResultForm and hide main form
        private void btnResult_Click(object sender, EventArgs e)
        {
            resultForm rs = new resultForm();
            this.Hide();  // Hide the current form (DowryWin)

            // Show ResultForm
            rs.Show();

            // Subscribe to the FormClosed event so when ResultForm closes, DowryWin will show again
            rs.FormClosed += (s, args) => this.Show();
        }

        private void btnShlr_Click(object sender, EventArgs e)
        {

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCgpa4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDprtmnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
