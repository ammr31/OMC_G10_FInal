using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is MainPage)
            {
                return;
            }
            // Open the Mobility Form
            MainPage newForm = new MainPage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }

        private void btnSupplierPage_Click_1(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is SupplierPage)
            {
                return;
            }
            // Open the Mobility Form
            SupplierPage newForm = new SupplierPage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }
    }
}
