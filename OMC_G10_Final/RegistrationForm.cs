using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private bool IsValidEmailFormat(string email)
        {
            return email.Contains("@") && email.Contains(".") &&
                   email.IndexOf("@") < email.LastIndexOf(".") &&
                   email.IndexOf("@") > 0;
        }

        private bool IsValidPhoneFormat(string phone)
        {
            // Allows digits, spaces, dashes, and an optional leading +
            // Requires at least 7 digits total (reasonable minimum for a business line)
            int digitCount = 0;
            foreach (char c in phone)
            {
                if (char.IsDigit(c)) digitCount++;
                else if (c != ' ' && c != '-' && c != '+') return false;
            }
            return digitCount >= 7;
        }

        private bool IsValidSSMFormat(string ssm)
        {
            // SSM registration numbers are numeric-only in your sample data (e.g. 202612468934)
            // Require a reasonable minimum length to catch obvious junk input
            foreach (char c in ssm)
            {
                if (!char.IsDigit(c)) return false;
            }
            return ssm.Length >= 8;
        }


        private bool EmailAlreadyExists(string email)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM [Suppliers] WHERE [BusinessEmail] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@BusinessEmail", OleDbType.VarWChar).Value = email;
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

        private bool SaveNewSupplier(string businessName, string ssmRegNumber, string businessAddress,
                                      string businessContact, string businessEmail, string type)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string newSupplierId = GenerateNextSupplierId(conn);
                    string password = $"Partner#Access63"; // e.g. Partner#AccessS05

                    string query = @"INSERT INTO [Suppliers] 
                        ([SupplierID], [BusinessName], [SSMRegNumber], [BusinessAddress], [BusinessContactNumber], [BusinessEmail], [Type], [Status], [Password], [RegisteredDate]) 
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SupplierID", OleDbType.VarWChar).Value = newSupplierId;
                        cmd.Parameters.Add("@BusinessName", OleDbType.VarWChar).Value = businessName;
                        cmd.Parameters.Add("@SSMRegNumber", OleDbType.VarWChar).Value = ssmRegNumber;
                        cmd.Parameters.Add("@BusinessAddress", OleDbType.VarWChar).Value = businessAddress;
                        cmd.Parameters.Add("@BusinessContactNumber", OleDbType.VarWChar).Value = businessContact;
                        cmd.Parameters.Add("@BusinessEmail", OleDbType.VarWChar).Value = businessEmail;
                        cmd.Parameters.Add("@Type", OleDbType.VarWChar).Value = type;
                        cmd.Parameters.Add("@Status", OleDbType.VarWChar).Value = "Active";
                        cmd.Parameters.Add("@Password", OleDbType.VarWChar).Value = password;
                        cmd.Parameters.Add("@RegisteredDate", OleDbType.Date).Value = DateTime.Now;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Error saving supplier: {ex.Message}");
                    return false;
                }
            }
        }

        private string GenerateNextSupplierId(OleDbConnection conn)
        {
            string query = "SELECT [SupplierID] FROM [Suppliers] ORDER BY [SupplierID] DESC";
            int maxNum = 0;

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["SupplierID"].ToString(); // e.g. "S04"
                    string numPart = lastId.Substring(1);             // "04"
                    int.TryParse(numPart, out maxNum);
                }
            }

            int nextNum = maxNum + 1;
            return "S" + nextNum.ToString("D2"); // S05, S06...
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbType = new AntdUI.Select();
            txtBusinessAddress = new AntdUI.Input();
            txtBusinessContact = new AntdUI.Input();
            txtBusinessEmail = new AntdUI.Input();
            txtSSMRegNumber = new AntdUI.Input();
            txtBusinessName = new AntdUI.Input();
            btnSubmitRegistration = new Button();
            label1 = new Label();
            pageHeader1 = new AntdUI.PageHeader();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(245, 247, 231);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbType);
            groupBox1.Controls.Add(txtBusinessAddress);
            groupBox1.Controls.Add(txtBusinessContact);
            groupBox1.Controls.Add(txtBusinessEmail);
            groupBox1.Controls.Add(txtSSMRegNumber);
            groupBox1.Controls.Add(txtBusinessName);
            groupBox1.Controls.Add(btnSubmitRegistration);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(125, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(994, 701);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(179, 466);
            label7.Name = "label7";
            label7.Size = new Size(220, 41);
            label7.TabIndex = 36;
            label7.Text = "Business Type :";
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(138, 240);
            label6.Name = "label6";
            label6.Size = new Size(259, 41);
            label6.TabIndex = 35;
            label6.Text = "Business Address :";
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(172, 407);
            label5.Name = "label5";
            label5.Size = new Size(225, 41);
            label5.TabIndex = 34;
            label5.Text = "Business Email :";
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, 352);
            label4.Name = "label4";
            label4.Size = new Size(252, 41);
            label4.TabIndex = 33;
            label4.Text = "Business Contact : ";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 184);
            label3.Name = "label3";
            label3.Size = new Size(360, 41);
            label3.TabIndex = 32;
            label3.Text = "SSM Registration Number :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 128);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 31;
            label2.Text = "Business Name :";
            // 
            // cmbType
            // 
            cmbType.BorderWidth = 2F;
            cmbType.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbType.Items.AddRange(new object[] { "Hospital", "Clinic", "Medical Supplier" });
            cmbType.Location = new Point(400, 456);
            cmbType.Name = "cmbType";
            cmbType.PlaceholderText = "Business Type";
            cmbType.Size = new Size(283, 51);
            cmbType.TabIndex = 30;
            // 
            // txtBusinessAddress
            // 
            txtBusinessAddress.BorderWidth = 2F;
            txtBusinessAddress.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusinessAddress.ForeColor = SystemColors.ControlText;
            txtBusinessAddress.Location = new Point(400, 231);
            txtBusinessAddress.Multiline = true;
            txtBusinessAddress.Name = "txtBusinessAddress";
            txtBusinessAddress.PlaceholderColor = SystemColors.ActiveBorder;
            txtBusinessAddress.PlaceholderText = "Business Address";
            txtBusinessAddress.Size = new Size(556, 105);
            txtBusinessAddress.TabIndex = 21;
            // 
            // txtBusinessContact
            // 
            txtBusinessContact.BorderWidth = 2F;
            txtBusinessContact.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusinessContact.ForeColor = SystemColors.ControlText;
            txtBusinessContact.Location = new Point(400, 342);
            txtBusinessContact.Name = "txtBusinessContact";
            txtBusinessContact.PlaceholderText = "Ex: 012-3456789";
            txtBusinessContact.Size = new Size(556, 51);
            txtBusinessContact.TabIndex = 19;
            // 
            // txtBusinessEmail
            // 
            txtBusinessEmail.BorderWidth = 2F;
            txtBusinessEmail.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusinessEmail.ForeColor = SystemColors.ControlText;
            txtBusinessEmail.Location = new Point(400, 399);
            txtBusinessEmail.Name = "txtBusinessEmail";
            txtBusinessEmail.PlaceholderText = "Ex: example@gmail.com";
            txtBusinessEmail.Size = new Size(556, 51);
            txtBusinessEmail.TabIndex = 18;
            // 
            // txtSSMRegNumber
            // 
            txtSSMRegNumber.BorderWidth = 2F;
            txtSSMRegNumber.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSSMRegNumber.ForeColor = SystemColors.ControlText;
            txtSSMRegNumber.Location = new Point(400, 174);
            txtSSMRegNumber.Name = "txtSSMRegNumber";
            txtSSMRegNumber.PlaceholderColor = SystemColors.ActiveBorder;
            txtSSMRegNumber.PlaceholderText = "Ex: 202401000123";
            txtSSMRegNumber.Size = new Size(556, 51);
            txtSSMRegNumber.TabIndex = 17;
            // 
            // txtBusinessName
            // 
            txtBusinessName.BorderWidth = 2F;
            txtBusinessName.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusinessName.ForeColor = SystemColors.ControlText;
            txtBusinessName.Location = new Point(400, 117);
            txtBusinessName.Name = "txtBusinessName";
            txtBusinessName.PlaceholderColor = SystemColors.ActiveBorder;
            txtBusinessName.PlaceholderText = "Business Name";
            txtBusinessName.Size = new Size(556, 51);
            txtBusinessName.TabIndex = 15;
            // 
            // btnSubmitRegistration
            // 
            btnSubmitRegistration.BackColor = Color.FromArgb(255, 192, 192);
            btnSubmitRegistration.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRegistration.Location = new Point(338, 578);
            btnSubmitRegistration.Name = "btnSubmitRegistration";
            btnSubmitRegistration.Size = new Size(345, 53);
            btnSubmitRegistration.TabIndex = 13;
            btnSubmitRegistration.Text = "SUBMIT";
            btnSubmitRegistration.UseVisualStyleBackColor = false;
            btnSubmitRegistration.Click += btnSubmitRegistration_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(193, 23);
            label1.Name = "label1";
            label1.Size = new Size(603, 57);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION FORM";
            // 
            // pageHeader1
            // 
            pageHeader1.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Icon = Properties.Resources.profilepink1;
            pageHeader1.IconRatio = 1F;
            pageHeader1.IconSvg = "";
            pageHeader1.Location = new Point(12, 12);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.Size = new Size(92, 74);
            pageHeader1.TabIndex = 43;
            pageHeader1.Text = "Back";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick_1;
            // 
            // label8
            // 
            label8.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(207, 523);
            label8.Name = "label8";
            label8.Size = new Size(667, 41);
            label8.TabIndex = 37;
            label8.Text = "Password has been autoset to Partner#Access63";
            // 
            // RegistrationForm
            // 
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(pageHeader1);
            Controls.Add(groupBox1);
            Name = "RegistrationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }



        private void btnSubmitRegistration_Click_1(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is ProfilePage)
            {
                return;
            }

            string businessName = txtBusinessName.Text?.Trim() ?? string.Empty;
            string ssmRegNumber = txtSSMRegNumber.Text?.Trim() ?? string.Empty;
            string businessAddress = txtBusinessAddress.Text?.Trim() ?? string.Empty;
            string businessContact = txtBusinessContact.Text?.Trim() ?? string.Empty;
            string businessEmail = txtBusinessEmail.Text?.Trim() ?? string.Empty;
            string type = cmbType.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(businessName) || string.IsNullOrEmpty(businessEmail) ||
                string.IsNullOrEmpty(ssmRegNumber) || string.IsNullOrEmpty(businessContact) ||
                string.IsNullOrEmpty(businessAddress) || string.IsNullOrEmpty(type))
            {
                CustomMessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!IsValidEmailFormat(businessEmail))
            {
                CustomMessageBox.Show("Please enter a valid business email address.");
                return;
            }

            if (!IsValidPhoneFormat(businessContact))
            {
                CustomMessageBox.Show("Please enter a valid contact number (at least 7 digits).");
                return;
            }

            if (!IsValidSSMFormat(ssmRegNumber))
            {
                CustomMessageBox.Show("SSM Registration Number must be numeric and at least 8 digits.");
                return;
            }

            if (EmailAlreadyExists(businessEmail))
            {
                CustomMessageBox.Show("An account with this email already exists.");
                return;
            }

            bool success = SaveNewSupplier(businessName, ssmRegNumber, businessAddress, businessContact, businessEmail, type);

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
        private GroupBox groupBox1;
        private AntdUI.Select cmbType;
        private AntdUI.Input txtBusinessAddress;
        private AntdUI.Input txtBusinessContact;
        private AntdUI.Input txtBusinessEmail;
        private AntdUI.Input txtSSMRegNumber;
        private AntdUI.Input txtBusinessName;
        private Button btnSubmitRegistration;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private AntdUI.PageHeader pageHeader1;
        private Label label8;
        private Label label1;

        private void pageHeader1_BackClick_1(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is loginpage)
            {
                return;
            }

            loginpage newForm = new loginpage();
            newForm.Show();

            this.Hide();
        }
    }
}