using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class BottomNavigationBar : UserControl
    {
        public BottomNavigationBar()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is MainPage)
            {
                return;
            }

            MainPage newForm = new MainPage();
            newForm.Show();

            if (currentForm != null)
            {
                currentForm.Hide(); // Use Hide instead of Close so the application loop stays alive
            }
        }

        private void btnLikedPage_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is LikedPage)
            {
                return;
            }

            LikedPage newForm = new LikedPage();
            newForm.Show();

            if (currentForm != null)
            {
                currentForm.Hide(); // Prevents the application from terminating
            }
        }

        private void btnCartPage_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is CartPage)
            {
                return;
            }

            CartPage newForm = new CartPage();
            newForm.Show();

            if (currentForm != null)
            {
                currentForm.Hide(); // Prevents the application from terminating
            }
        }

        private void btnProfilePage_Click(object sender, EventArgs e)
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
    }
}
