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
            if (!Session.IsAdmin && !Session.IsSupplier)
            {
                MessageBox.Show("Access denied. This page is for suppliers and administrators only.");
                return;
            }
            SupplierPage newForm = new SupplierPage();
            newForm.Show();

            this.Hide();
        }

        private void btnadminpage_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is adminpage)
            {
                return;
            }

            if (!Session.IsAdmin)
            {
                MessageBox.Show("Access denied. This page is for administrators only.");
                return;
            }

            adminpage newForm = new adminpage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }
        private void LoadProfile()
        {
            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                MessageBox.Show("No user is currently logged in.");
                return;
            }

            if (Session.IsAdmin)
            {
                LoadAdminProfile();
            }
            else if (Session.IsSupplier)
            {
                LoadSupplierProfile();
            }
            else
            {
                LoadUserProfile();
            }
        }

        private void LoadSupplierProfile()
        {
            DataRow supplier = DatabaseHelper.GetSupplierById(Session.CurrentUserId);

            if (supplier == null)
            {
                MessageBox.Show("Supplier record not found.");
                return;
            }

            txtName.Text = supplier["BusinessName"].ToString();
            txtEmail.Text = supplier["BusinessEmail"].ToString();
            txtPhoneNumber.Text = supplier["BusinessContactNumber"].ToString();
            txtaddress.Text = supplier["BusinessAddress"].ToString();

            // Suppliers don't have Gender/UserCategory - clear and disable
            radMale.Checked = false;
            radfemale.Checked = false;

            // Disable every field - display only for suppliers
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtaddress.Enabled = false;
            radMale.Enabled = false;
            radfemale.Enabled = false;
            slctusercategory.Enabled = false;
        }

        private void LoadUserProfile()
        {
            DataRow user = DatabaseHelper.GetUserById(Session.CurrentUserId);

            if (user == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            txtName.Text = user["Name"].ToString();
            txtEmail.Text = user["Email"].ToString();
            txtPhoneNumber.Text = user["PhoneNumber"].ToString();
            txtaddress.Text = user.Table.Columns.Contains("Address") ? user["Address"].ToString() : "";

            string gender = user["Gender"].ToString();
            if (gender == "Male") radMale.Checked = true;
            else if (gender == "Female") radfemale.Checked = true;

            string category = user["UserCategory"].ToString();
            int categoryIndex = -1;
            for (int i = 0; i < slctusercategory.Items.Count; i++)
            {
                if (slctusercategory.Items[i].ToString() == category)
                {
                    categoryIndex = i;
                    break;
                }
            }

            if (categoryIndex >= 0)
                slctusercategory.SelectedIndex = categoryIndex;
        }

        private void LoadAdminProfile()
        {
            DataRow admin = DatabaseHelper.GetAdminById(Session.CurrentUserId);

            if (admin == null)
            {
                MessageBox.Show("Admin record not found.");
                return;
            }

            txtName.Text = admin["Name"].ToString();
            txtEmail.Text = admin["Email"].ToString();

            // Admin table has no PhoneNumber/Address/Gender/UserCategory,
            // so disable or hide the fields that don't apply
            txtPhoneNumber.Text = "";
            txtaddress.Text = "";
            txtPhoneNumber.Enabled = false;
            txtaddress.Enabled = false;
            radMale.Enabled = false;
            radfemale.Enabled = false;
            slctusercategory.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (Session.IsSupplier)
            {
                MessageBox.Show("Supplier details can't be edited here. Contact customer support to manage your business info.");
                return;
            }
            if (Session.IsAdmin)
            {
                string adminName = txtName.Text?.Trim() ?? "";
                string adminEmail = txtEmail.Text?.Trim() ?? "";

                if (string.IsNullOrEmpty(adminName) || string.IsNullOrEmpty(adminEmail))
                {
                    MessageBox.Show("Name and Email are required.");
                    return;
                }

                bool adminSuccess = DatabaseHelper.UpdateAdminProfile(Session.CurrentUserId, adminName, adminEmail);

                if (adminSuccess)
                    MessageBox.Show("Profile updated successfully.");
                else
                    MessageBox.Show("Failed to update profile.");

                return;
            }

            string name = txtName.Text?.Trim() ?? "";
            string email = txtEmail.Text?.Trim() ?? "";
            string phone = txtPhoneNumber.Text?.Trim() ?? "";
            string address = txtaddress.Text?.Trim() ?? "";
            string gender = radMale.Checked ? "Male" : radfemale.Checked ? "Female" : "";
            string category = slctusercategory.Text?.Trim() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Name and Email are required.");
                return;
            }

            bool success = DatabaseHelper.UpdateUserProfile(
                Session.CurrentUserId, name, email, phone, address, gender, category);

            if (success)
                MessageBox.Show("Profile updated successfully.");
            else
                MessageBox.Show("Failed to update profile.");
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUserId = null;
            Session.IsAdmin = false;
            Session.IsSupplier = false;

            loginpage newForm = new loginpage();
            newForm.Show();
            this.Hide();
        }
    }
}
