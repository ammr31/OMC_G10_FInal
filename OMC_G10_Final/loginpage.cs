using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
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
                currentForm.Hide(); // Use Hide instead of Close so the application loop stays alive
            }
        }

        private void btnregister_Click_1(object sender, EventArgs e)
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
                currentForm.Hide(); // Use Hide instead of Close so the application loop stays alive
            }
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
    }
}
