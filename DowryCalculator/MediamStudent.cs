using System;
using System.Windows.Forms;

namespace DowryCalculator
{
    public partial class MediamStudent : Form
    {

        public MediamStudent()
        {
            InitializeComponent();

        }


        private void pnlMediam_Paint(object sender, PaintEventArgs e)
        {

        }


        private void lblTaka_Click(object sender, EventArgs e)
        {

        }

        private void lblBike_Click(object sender, EventArgs e)
        {

        }

        private void lblInfoResult_Click(object sender, EventArgs e)
        {

        }

        private void lblNameMedium_Click(object sender, EventArgs e)
        {

        }

        private void lblCgpaMedium_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartmentMedium_Click(object sender, EventArgs e)
        {

        }

        private void lblSemisterMedium_Click(object sender, EventArgs e)
        {

        }

        private void btnBackMedium_Click(object sender, EventArgs e)
        {
            DowryWin d = new DowryWin();
            this.Hide();
            d.Show();
        }
    }
}