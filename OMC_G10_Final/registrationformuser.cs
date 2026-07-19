using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OMC_G10_Final
{
    public partial class registrationformuser : Form
    {
        public registrationformuser()
        {
            InitializeComponent();
        }



        private void btnSubmitRegistration_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is loginpage)
            {
                return;
            }

            // Replace these with your actual textbox/control names
            string name = txtname.Text.Trim();
            string gender = slctGender.Text.Trim();
            string phone = txtContactNum.Text.Trim();
            string email = txtEmail.Text.Trim();
            string userCategory = slctUserCategory.Text.Trim();
            string idType = slctIDType.Text.Trim();
            string idNumber = txtid.Text.Trim();
            string password = txtpassword.Text.Trim();
            string confirmPassword = txtconfirmpassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("Please fill in all required fields."); return;
            }

            if (password != confirmPassword)
            {
                CustomMessageBox.Show("Passwords do not match.");
                return;
            }

            if (EmailAlreadyExists(email))
            {
                CustomMessageBox.Show("An account with this email already exists.");
                return;
            }

            bool success = SaveNewUser(name, gender, phone, email, userCategory, idType, idNumber, password);

            if (!success)
            {
                CustomMessageBox.Show("Something went wrong. Please try again.");
                return;
            }

            CustomMessageBox.Show("Account has been created.");

            loginpage newForm = new loginpage();
            newForm.Show();

            this.Hide();
        }

        private bool EmailAlreadyExists(string email)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM [Users] WHERE [Email] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error checking email: {ex.Message}");
                    return true; // fail safe — block registration if check fails
                }
            }
        }

        private bool SaveNewUser(string name, string gender, string phone, string email,
                          string userCategory, string idType, string idNumber, string password)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string newUserId = GenerateNextUserId(conn);

                    string query = @"INSERT INTO [Users] 
                ([UserID], [Name], [Gender], [PhoneNumber], [Email], [UserCategory], [IDType], [IDNumber], [Password], [RegisteredDate]) 
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@UserID", OleDbType.VarWChar).Value = newUserId;
                        cmd.Parameters.Add("@Name", OleDbType.VarWChar).Value = name;
                        cmd.Parameters.Add("@Gender", OleDbType.VarWChar).Value = gender;
                        cmd.Parameters.Add("@PhoneNumber", OleDbType.VarWChar).Value = phone;
                        cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = email;
                        cmd.Parameters.Add("@UserCategory", OleDbType.VarWChar).Value = userCategory;
                        cmd.Parameters.Add("@IDType", OleDbType.VarWChar).Value = idType;
                        cmd.Parameters.Add("@IDNumber", OleDbType.VarWChar).Value = idNumber;
                        cmd.Parameters.Add("@Password", OleDbType.VarWChar).Value = password;
                        cmd.Parameters.Add("@RegisteredDate", OleDbType.Date).Value = DateTime.Now;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error saving user: {ex.Message}");
                    return false;
                }
            }
        }

        private string GenerateNextUserId(OleDbConnection conn)
        {
            // Generates U003, U004, etc. based on existing max UserID
            string query = "SELECT [UserID] FROM [Users] ORDER BY [UserID] DESC";
            int maxNum = 0;

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["UserID"].ToString(); // e.g. "U002"
                    string numPart = lastId.Substring(1);         // "002"
                    int.TryParse(numPart, out maxNum);
                }
            }

            int nextNum = maxNum + 1;
            return "U" + nextNum.ToString("D3"); // U003, U004...
        }

        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is loginpage)
            {
                return;
            }
            // Open the Mobility Form
            loginpage newForm = new loginpage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }
    }
}