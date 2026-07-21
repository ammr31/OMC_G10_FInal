using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

            string email = txtemail.Text?.Trim() ?? string.Empty;
            string password = txtpassword.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("Please enter both email and password.");
                return;
            }

            if (!IsValidEmailFormat(email))
            {
                CustomMessageBox.Show("Please enter a valid email address (must contain '@' and '.').");
                return;
            }

            if (!IsValidPasswordFormat(password))
            {
                CustomMessageBox.Show("Password must contain at least one capital letter, one small letter and one number and to have atleast 8 characters.");
                return;
            }

            Session.IsSupplier = false; // reset before checking

            // Try Admin first
            if (AuthenticateAdmin(email, password))
            {
                ProfilePage newForm = new ProfilePage();
                newForm.Show();
                if (currentForm != null) currentForm.Hide();
                return;
            }

            // Then try Suppliers
            if (AuthenticateSupplier(email, password))
            {
                ProfilePage newForm = new ProfilePage();
                newForm.Show();
                if (currentForm != null) currentForm.Hide();
                return;
            }

            // Then try normal Users
            if (AuthenticateUser(email, password))
            {
                ProfilePage newForm = new ProfilePage();
                newForm.Show();
                if (currentForm != null) currentForm.Hide();
                return;
            }

            CustomMessageBox.Show("Invalid email or password.");
        }
        private bool AuthenticateAdmin(string email, string password)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT [AdminID], [Password] FROM [Admin] WHERE [Email] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();
                                string adminId = reader["AdminID"].ToString();

                                if (storedPassword == password)
                                {
                                    Session.CurrentUserId = adminId; // <-- add this
                                    Session.IsAdmin = true;
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Admin login error: {ex.Message}");
                }
            }

            return false;
        }

        private bool AuthenticateUser(string email, string password)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT [UserID], [Password] FROM [Users] WHERE [Email] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();
                                string userId = reader["UserID"].ToString();

                                if (storedPassword == password)
                                {
                                    Session.CurrentUserId = userId; // <-- add this
                                    Session.IsAdmin = false;
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"User login error: {ex.Message}");
                }
            }

            return false;
        }

        private void UpdateAdminLastLogin(string adminId)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE [Admin] SET [LastLogin] = ? WHERE [AdminID] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LastLogin", DateTime.Now);
                        cmd.Parameters.AddWithValue("@AdminID", adminId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    // non-critical, don't block login if this fails
                }
            }
        }

        public class RegisterChoiceForm : Form
        {
            public bool RegisterAsSupplier { get; private set; } = false;
            public bool RegisterAsAdmin { get; private set; } = false;
            public bool ChoiceMade { get; private set; } = false;

            private Button btnUser;
            private Button btnSupplier;
            private Button btnAdmin;

            public RegisterChoiceForm()
            {
                this.Text = "Register As";
                this.BackColor = Color.FromArgb(108, 117, 82);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Size = new Size(640, 300);

                Label lbl = new Label
                {
                    Text = "How would you like to register?",
                    ForeColor = Color.White,
                    Font = new Font("Verdana", 10, FontStyle.Bold),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 80
                };

                int btnWidth = 170;
                int btnHeight = 50;
                int spacing = 15;
                int totalWidth = (btnWidth * 3) + (spacing * 2);
                int startX = (this.ClientSize.Width - totalWidth) / 2;

                btnUser = new Button
                {
                    Text = "Register as Supplier",
                    Font = new Font("Verdana", 9, FontStyle.Bold),
                    Size = new Size(btnWidth, btnHeight),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(108, 117, 82),
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(startX, 120)
                };
                btnUser.FlatAppearance.BorderSize = 0;
                btnUser.Click += (s, e) =>
                {
                    RegisterAsSupplier = false;
                    RegisterAsAdmin = false;
                    ChoiceMade = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                };

                btnSupplier = new Button
                {
                    Text = "Register as User",
                    Font = new Font("Verdana", 9, FontStyle.Bold),
                    Size = new Size(btnWidth, btnHeight),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(108, 117, 82),
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(startX + btnWidth + spacing, 120)
                };
                btnSupplier.FlatAppearance.BorderSize = 0;
                btnSupplier.Click += (s, e) =>
                {
                    RegisterAsSupplier = true;
                    RegisterAsAdmin = false;
                    ChoiceMade = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                };

                btnAdmin = new Button
                {
                    Text = "Register as Admin",
                    Font = new Font("Verdana", 9, FontStyle.Bold),
                    Size = new Size(btnWidth, btnHeight),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(108, 117, 82),
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(startX + (btnWidth + spacing) * 2, 120)
                };
                btnAdmin.FlatAppearance.BorderSize = 0;
                btnAdmin.Click += (s, e) =>
                {
                    RegisterAsSupplier = false;
                    RegisterAsAdmin = true;
                    ChoiceMade = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                };

                this.Controls.Add(lbl);
                this.Controls.Add(btnUser);
                this.Controls.Add(btnSupplier);
                this.Controls.Add(btnAdmin);
            }
        }
        private bool AuthenticateSupplier(string email, string password)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT [SupplierID], [Password], [Status] FROM [Suppliers] WHERE [BusinessEmail] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BusinessEmail", email);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();
                                string supplierId = reader["SupplierID"].ToString();
                                string status = reader["Status"].ToString();

                                if (status != "Active")
                                {
                                    CustomMessageBox.Show("This supplier account is inactive. Please contact admin.");
                                    return false;
                                }

                                if (storedPassword == password)
                                {
                                    Session.CurrentUserId = supplierId;
                                    Session.IsAdmin = false;
                                    Session.IsSupplier = true;
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Supplier login error: {ex.Message}");
                }
            }

            return false;
        }



        private void btnregister_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is registrationformuser || currentForm is RegistrationForm)
            {
                return;
            }

            using (RegisterChoiceForm choiceForm = new RegisterChoiceForm())
            {
                DialogResult result = choiceForm.ShowDialog(currentForm);

                if (result != DialogResult.OK || !choiceForm.ChoiceMade)
                {
                    return;
                }

                Form newForm;
                if (choiceForm.RegisterAsAdmin)
                {
                    newForm = new registrationformuser(true); // admin mode
                }
                else if (choiceForm.RegisterAsSupplier)
                {
                    newForm = new registrationformuser();
                }
                else
                {
                    newForm = new RegistrationForm();
                }

                newForm.Show();

                if (currentForm != null)
                {
                    currentForm.Hide();
                }
            }
        }



        private void checkbox1_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (e.Value) // shows password when checked
            {
                txtpassword.PasswordChar = '\0'; // '\0' reveals the actual characters
            }
            else
            {
                txtpassword.PasswordChar = '*'; // masks it again when unchecked
            }
        }
        private bool IsValidEmailFormat(string email)
        {
            return email.Contains("@") && email.Contains(".");
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