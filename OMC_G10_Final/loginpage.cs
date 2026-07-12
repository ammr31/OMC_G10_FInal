using Microsoft.Win32;
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

        public class RegisterChoiceForm : Form
        {
            public bool RegisterAsSupplier { get; private set; } = false;
            public bool ChoiceMade { get; private set; } = false;

            private Button btnUser;
            private Button btnSupplier;

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

                btnUser = new Button
                {
                    Text = "Register as Supplier",
                    Font = new Font("Verdana", 10, FontStyle.Bold),
                    Size = new Size(250, 40),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(108, 117, 82),
                    FlatStyle = FlatStyle.Flat,
                };
                btnUser.FlatAppearance.BorderSize = 0;
                btnUser.Location = new Point((this.ClientSize.Width / 2) - btnUser.Width - 15, 120);
                btnUser.Click += (s, e) =>
                {
                    RegisterAsSupplier = false;
                    ChoiceMade = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                };

                btnSupplier = new Button
                {
                    Text = "Register as User",
                    Font = new Font("Verdana", 10, FontStyle.Bold),
                    Size = new Size(250, 40),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(108, 117, 82),
                    FlatStyle = FlatStyle.Flat,
                };
                btnSupplier.FlatAppearance.BorderSize = 0;
                btnSupplier.Location = new Point((this.ClientSize.Width / 2) + 15, 120);
                btnSupplier.Click += (s, e) =>
                {
                    RegisterAsSupplier = true;
                    ChoiceMade = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                };

                this.Controls.Add(lbl);
                this.Controls.Add(btnUser);
                this.Controls.Add(btnSupplier);
            }
        }

        private void btnregister_Click_1(object sender, EventArgs e)
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
                    // User closed the popup without choosing
                    return;
                }

                Form newForm = choiceForm.RegisterAsSupplier
                    ? new registrationformuser()
                    : new RegistrationForm();

                newForm.Show();

                if (currentForm != null)
                {
                    currentForm.Hide(); // Use Hide instead of Close so the application loop stays alive
                }
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
