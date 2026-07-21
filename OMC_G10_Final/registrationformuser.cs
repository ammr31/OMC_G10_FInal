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
        private bool isAdminMode = false;
        private string jkmCardId = string.Empty;
        public registrationformuser()
        {
            InitializeComponent();
            slctIDType.SelectedIndexChanged += slctIDType_SelectedIndexChanged;
        }

        public registrationformuser(bool adminMode)
        {
            InitializeComponent();
            isAdminMode = adminMode;

            SetupFormMode();
        }

        private void SetupFormMode()
        {
            if (isAdminMode)
            {
                slctGender.Enabled = false;
                txtContactNum.Enabled = false;
                slctUserCategory.Enabled = false;
                slctIDType.Enabled = false;
                txtid.Enabled = false;
                txtpassword.Enabled = false;
                txtconfirmpassword.Enabled = false;

                slctGender.SelectedIndex = -1;
                txtContactNum.Clear();
                slctUserCategory.SelectedIndex = -1;
                slctIDType.SelectedIndex = -1;
                txtid.Clear();
                txtpassword.Clear();
                txtconfirmpassword.Clear();

                lblAdminPasswordNotice.Visible = true; // <-- show the hint only in admin mode

                this.Text = "Admin Registration";
                btnSubmitRegistration.Text = "Register Admin";
            }
        }

        private void slctIDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adjust this string to match your actual dropdown item exactly
            if (slctIDType.Text.Trim() == "OKU Card" || slctIDType.SelectedIndex == 1)
            {
                using (JKMCardDialog dialog = new JKMCardDialog())
                {
                    DialogResult result = dialog.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        jkmCardId = dialog.JKMCardId;
                    }
                    else
                    {
                        // User cancelled - revert selection so they can't proceed silently
                        slctIDType.SelectedIndex = -1;
                        jkmCardId = string.Empty;
                    }
                }
            }
            else
            {
                jkmCardId = string.Empty;
            }
        }



        private void btnSubmitRegistration_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is loginpage)
            {
                return;
            }

            string name = txtname.Text.Trim();
            string email = txtEmail.Text.Trim();

            string password;
            string confirmPassword;

            if (isAdminMode)
            {
                password = "Admin12345_";
                confirmPassword = "Admin12345_";
            }
            else
            {
                password = txtpassword.Text.Trim();
                confirmPassword = txtconfirmpassword.Text.Trim();
            }

            // --- Admin path: only Name + Email matter ---
            if (isAdminMode)
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
                {
                    CustomMessageBox.Show("Please fill in name and email.");
                    return;
                }

                if (!IsValidNameFormat(name))
                {
                    CustomMessageBox.Show("Please enter a valid name (letters only).");
                    return;
                }

                if (!IsValidEmailFormat(email))
                {
                    CustomMessageBox.Show("Please enter a valid email address.");
                    return;
                }

                if (AdminEmailAlreadyExists(email))
                {
                    CustomMessageBox.Show("An admin account with this email already exists.");
                    return;
                }

                bool adminSaved = SaveNewAdmin(name, email, password);

                if (!adminSaved)
                {
                    CustomMessageBox.Show("Something went wrong. Please try again.");
                    return;
                }

                CustomMessageBox.Show("Admin account has been created.");

                loginpage newLogin = new loginpage();
                newLogin.Show();
                this.Hide();
                return;
            }

            // --- Existing normal-user path below (unchanged) ---
            string gender = slctGender.Text.Trim();
            string phone = txtContactNum.Text.Trim();
            string userCategory = slctUserCategory.Text.Trim();
            string idType = slctIDType.Text.Trim();
            string idNumber = txtid.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(userCategory) ||
                string.IsNullOrEmpty(idType))
            {
                CustomMessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!IsValidNameFormat(name))
            {
                CustomMessageBox.Show("Please enter a valid name (letters only).");
                return;
            }

            if (!IsValidEmailFormat(email))
            {
                CustomMessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!IsValidPhoneFormat(phone))
            {
                CustomMessageBox.Show("Please enter a valid contact number (at least 10 digits and have a dash).");
                return;
            }

            if (!IsValidPasswordFormat(password))
            {
                CustomMessageBox.Show("Password must be at least 8 characters and contain both capital letters, small letter and numbers.");
                return;
            }

            if (password != confirmPassword)
            {
                CustomMessageBox.Show("Passwords do not match.");
                return;
            }

            if (idType == "OKU Card" && string.IsNullOrEmpty(jkmCardId))
            {
                CustomMessageBox.Show("Please provide your JKM Card ID before continuing.");
                return;
            }

            if (idType == "OKU Card")
            {
                idNumber = jkmCardId;
            }
            else if (string.IsNullOrEmpty(idNumber))
            {
                CustomMessageBox.Show("Please enter your ID number.");
                return;
            }

            if (EmailAlreadyExists(email))
            {
                CustomMessageBox.Show("An account with this email already exists.");
                return;
            }

            if (IdNumberAlreadyExists(idNumber))
            {
                CustomMessageBox.Show("An account with this ID number already exists.");
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

        private bool AdminEmailAlreadyExists(string email)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM [Admin] WHERE [Email] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error checking admin email: {ex.Message}");
                    return true; // fail safe
                }
            }
        }

        private bool SaveNewAdmin(string name, string email, string password)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string newAdminId = GenerateNextAdminId(conn);

                    string query = @"INSERT INTO [Admin] 
                ([AdminID], [Name], [Email], [Password], [LastLogin]) 
                VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@AdminID", OleDbType.VarWChar).Value = newAdminId;
                        cmd.Parameters.Add("@Name", OleDbType.VarWChar).Value = name;
                        cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = email;
                        cmd.Parameters.Add("@Password", OleDbType.VarWChar).Value = password;
                        cmd.Parameters.Add("@LastLogin", OleDbType.Date).Value = DateTime.Now;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error saving admin: {ex.Message}");
                    return false;
                }
            }
        }

        private string GenerateNextAdminId(OleDbConnection conn)
        {
            // Generates AD03, AD04, etc. based on existing max AdminID (matches AD01/AD02 already in the table)
            string query = "SELECT [AdminID] FROM [Admin] ORDER BY [AdminID] DESC";
            int maxNum = 0;

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["AdminID"].ToString(); // e.g. "AD02"
                    string numPart = lastId.Substring(2);          // "02"
                    int.TryParse(numPart, out maxNum);
                }
            }

            int nextNum = maxNum + 1;
            return "AD" + nextNum.ToString("D2"); // AD03, AD04...
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

        private bool IsValidEmailFormat(string email)
        {
            return email.Contains("@") && email.Contains(".") &&
                   email.IndexOf("@") < email.LastIndexOf(".") &&
                   email.IndexOf("@") > 0;
        }

        private bool IsValidPhoneFormat(string phone)
        {
            int digitCount = 0;
            bool hasDash = false;

            foreach (char c in phone)
            {
                if (char.IsDigit(c)) digitCount++;
                else if (c == '-') hasDash = true;
                else if (c != ' ' && c != '+') return false;
            }

            return digitCount >= 10 && hasDash;
        }

        private bool IsValidPasswordFormat(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit && password.Length >= 8;
        }

        private bool IsValidNameFormat(string name)
        {
            // Letters and spaces only, reject names that are just numbers or symbols
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '\'' && c != '-') return false;
            }
            return name.Length >= 2;
        }

        private bool IdNumberAlreadyExists(string idNumber)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM [Users] WHERE [IDNumber] = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDNumber", idNumber);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
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