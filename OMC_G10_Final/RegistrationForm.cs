using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSubmitRegistration = new Button();
            txtLicenceNum = new TextBox();
            txtBusinessEmail = new TextBox();
            txtBusinessContactNum = new TextBox();
            txtBusinessAddress = new TextBox();
            txtBusinessRegistrationNumberSSM = new TextBox();
            txtBusinessname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pageHeader1 = new AntdUI.PageHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(245, 247, 231);
            groupBox1.Controls.Add(btnSubmitRegistration);
            groupBox1.Controls.Add(txtLicenceNum);
            groupBox1.Controls.Add(txtBusinessEmail);
            groupBox1.Controls.Add(txtBusinessContactNum);
            groupBox1.Controls.Add(txtBusinessAddress);
            groupBox1.Controls.Add(txtBusinessRegistrationNumberSSM);
            groupBox1.Controls.Add(txtBusinessname);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(138, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(913, 534);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnSubmitRegistration
            // 
            btnSubmitRegistration.BackColor = Color.FromArgb(255, 192, 192);
            btnSubmitRegistration.Font = new Font("Verdana", 13.8F, FontStyle.Italic);
            btnSubmitRegistration.Location = new Point(290, 421);
            btnSubmitRegistration.Name = "btnSubmitRegistration";
            btnSubmitRegistration.Size = new Size(345, 53);
            btnSubmitRegistration.TabIndex = 13;
            btnSubmitRegistration.Text = "SUBMIT";
            btnSubmitRegistration.UseVisualStyleBackColor = false;
            btnSubmitRegistration.Click += btnSubmitRegistration_Click;
            // 
            // txtLicenceNum
            // 
            txtLicenceNum.ForeColor = Color.Gray;
            txtLicenceNum.Location = new Point(397, 362);
            txtLicenceNum.Name = "txtLicenceNum";
            txtLicenceNum.Size = new Size(440, 27);
            txtLicenceNum.TabIndex = 12;
            txtLicenceNum.Text = "(for hospital only)";
            txtLicenceNum.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBusinessEmail
            // 
            txtBusinessEmail.Location = new Point(397, 319);
            txtBusinessEmail.Name = "txtBusinessEmail";
            txtBusinessEmail.Size = new Size(440, 27);
            txtBusinessEmail.TabIndex = 11;
            // 
            // txtBusinessContactNum
            // 
            txtBusinessContactNum.Location = new Point(397, 276);
            txtBusinessContactNum.Name = "txtBusinessContactNum";
            txtBusinessContactNum.Size = new Size(440, 27);
            txtBusinessContactNum.TabIndex = 10;
            // 
            // txtBusinessAddress
            // 
            txtBusinessAddress.Location = new Point(397, 235);
            txtBusinessAddress.Name = "txtBusinessAddress";
            txtBusinessAddress.Size = new Size(440, 27);
            txtBusinessAddress.TabIndex = 9;
            // 
            // txtBusinessRegistrationNumberSSM
            // 
            txtBusinessRegistrationNumberSSM.Location = new Point(397, 195);
            txtBusinessRegistrationNumberSSM.Name = "txtBusinessRegistrationNumberSSM";
            txtBusinessRegistrationNumberSSM.Size = new Size(440, 27);
            txtBusinessRegistrationNumberSSM.TabIndex = 8;
            // 
            // txtBusinessname
            // 
            txtBusinessname.Location = new Point(397, 158);
            txtBusinessname.Name = "txtBusinessname";
            txtBusinessname.Size = new Size(440, 27);
            txtBusinessname.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(108, 365);
            label7.Name = "label7";
            label7.Size = new Size(235, 20);
            label7.TabIndex = 6;
            label7.Text = "Licence / Registration Number : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(108, 322);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 5;
            label6.Text = "Business E-mail Address : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 279);
            label5.Name = "label5";
            label5.Size = new Size(202, 20);
            label5.TabIndex = 4;
            label5.Text = "Business Contact Number : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 238);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 3;
            label4.Text = "Business Address :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 198);
            label3.Name = "label3";
            label3.Size = new Size(276, 20);
            label3.TabIndex = 2;
            label3.Text = "Business Registration Number (SSM) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 161);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Business Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(156, 57);
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
            pageHeader1.TabIndex = 41;
            pageHeader1.Text = "Back";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // RegistrationForm
            // 
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(pageHeader1);
            Controls.Add(groupBox1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        private GroupBox groupBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSubmitRegistration;
        private TextBox txtLicenceNum;
        private TextBox txtBusinessEmail;
        private TextBox txtBusinessContactNum;
        private TextBox txtBusinessAddress;
        private TextBox txtBusinessRegistrationNumberSSM;
        private AntdUI.PageHeader pageHeader1;
        private TextBox txtBusinessname;

        private void btnSubmitRegistration_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is ProfilePage)
            {
                return;
            }

            CustomMessageBox.Show("Account has been created.");

            ProfilePage newForm = new ProfilePage();
            newForm.Show();

            this.Hide();
        }
        public partial class CustomMessageBox : Form
        {
            public CustomMessageBox(string message, string title = "Message")
            {
                this.Text = title;
                this.BackColor = Color.FromArgb(108, 117, 82);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Size = new Size(640, 300);

                Label lbl = new Label
                {
                    Text = message,
                    ForeColor = Color.White,
                    Font = new Font("Verdana", 10, FontStyle.Bold),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 80
                };

                Button btnOk = new Button
                {
                    Text = "OK",
                    Font = new Font("Verdana", 10, FontStyle.Bold),
                    DialogResult = DialogResult.OK,
                    Size = new Size(80, 30),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(108, 117, 82),
                    FlatStyle = FlatStyle.Flat,
                };
                btnOk.FlatAppearance.BorderSize = 0;
                btnOk.Location = new Point((this.ClientSize.Width - btnOk.Width) / 2, 90);

                this.Controls.Add(lbl);
                this.Controls.Add(btnOk);
                this.AcceptButton = btnOk;
            }

            public static void Show(string message, string title = "Message")
            {
                using (CustomMessageBox box = new CustomMessageBox(message, title))
                {
                    box.ShowDialog();
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
