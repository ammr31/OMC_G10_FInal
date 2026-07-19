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

        private void btnHomePage_Click_1(object sender, EventArgs e)
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
                currentForm.Close(); // was Hide()
            }
        }

        private void btnRecentPage_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is RecentPage)
            {
                return;
            }

            RecentPage newForm = new RecentPage();
            newForm.Show();

            if (currentForm != null)
            {
                currentForm.Close(); // was Hide()
            }
        }

        private void btnCartPage_Click_1(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                MessageBox.Show("No user is logged in.");
                return;
            }

            if (currentForm is CartPage)
            {
                return;
            }

            CartPage cartPage = new CartPage();
            cartPage.Show();

            if (currentForm != null)
            {
                currentForm.Close(); // fixed: was "this.Hide()" which hid the wrong thing
            }
        }

        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (!string.IsNullOrEmpty(Session.CurrentUserId))
            {
                if (currentForm is ProfilePage)
                {
                    return;
                }

                ProfilePage newForm = new ProfilePage();
                newForm.Show();

                if (currentForm != null)
                {
                    currentForm.Close(); // was Hide()
                }
            }
            else
            {
                if (currentForm is loginpage)
                {
                    return;
                }

                loginpage newForm = new loginpage();
                newForm.Show();

                if (currentForm != null)
                {
                    currentForm.Close(); // was Hide()
                }
            }
        }
    }
}