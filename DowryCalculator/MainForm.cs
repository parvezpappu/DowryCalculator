using System;
using System.Windows.Forms;

namespace DowryCalculator
{
    public partial class DowryWin : Form
    {


        public DowryWin()
        {
            InitializeComponent();
            //cmbMain.Items.Add("Probation (<2.50)");
            //cmbMain.Items.Add("2.50 - 3.00");
            //cmbMain.Items.Add("3.00 - 3.50");
            //cmbMain.Items.Add("3.50 - 3.99");
            //cmbMain.Items.Add("Tourist 4.00");

        }


        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void btnCgpa_Click(object sender, EventArgs e)
        {
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

        private void cmbMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnResult_Click(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedItem = cmbMain.SelectedItem?.ToString();


            // Check if the selected item is "2.50 - 3.00"
            if (selectedItem == "2.50 - 3.00")
            {
                // Open the MediamStudent form
                MediamStudent ms = new MediamStudent();
                this.Hide();    //hide main
                ms.ShowDialog();  // show the medium
                                  // this.Show(); // show the main when close
            }
            else
            {
                // Show a message if the condition is not met
                MessageBox.Show("Please select '2.50 - 3.00' to proceed.");
            }
        }



    }
}