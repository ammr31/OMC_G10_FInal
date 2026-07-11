using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class SupplierPage : Form
    {
        public SupplierPage()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is ProfilePage)
            {
                return;
            }

            ProfilePage newForm = new ProfilePage();
            newForm.Show();

            if (currentForm != null)
            {
                currentForm.Hide(); // Prevents the application from terminating
            }

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is RegistrationForm)
            {
                return;
            }

            RegistrationForm newForm = new RegistrationForm();
            newForm.Show();

            if (currentForm != null)
            {
                currentForm.Hide(); // Prevents the application from terminating
            }

        }
    }
}
