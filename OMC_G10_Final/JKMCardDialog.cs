using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OMC_G10_Final
{
    public class JKMCardDialog : Form
    {
        public string JKMCardId { get; private set; } = string.Empty;

        private TextBox txtJKMId;

        public JKMCardDialog()
        {
            this.Text = "JKM Card Verification";
            this.Size = new Size(420, 220);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 231);

            Label lbl = new Label
            {
                Text = "Please enter your JKM (OKU) Card ID:",
                Font = new Font("Verdana", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(128, 64, 0),
                AutoSize = true,
                Location = new Point(20, 20)
            };
            this.Controls.Add(lbl);

            txtJKMId = new TextBox
            {
                Font = new Font("Verdana", 10),
                Location = new Point(20, 55),
                Size = new Size(360, 30)
            };
            this.Controls.Add(txtJKMId);

            Button btnConfirm = new Button
            {
                Text = "Confirm",
                Size = new Size(120, 40),
                Location = new Point(20, 110),
                BackColor = Color.FromArgb(255, 200, 220),
                FlatStyle = FlatStyle.Flat
            };
            btnConfirm.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtJKMId.Text))
                {
                    CustomMessageBox.Show("JKM Card ID is required to register under this category.");
                    return;
                }
                JKMCardId = txtJKMId.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
            this.Controls.Add(btnConfirm);

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Size = new Size(100, 40),
                Location = new Point(160, 110),
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
            this.Controls.Add(btnCancel);

            btnConfirm.Click += (s, e) =>
            {
                string input = txtJKMId.Text.Trim().ToUpper();

                if (string.IsNullOrWhiteSpace(input))
                {
                    CustomMessageBox.Show("JKM Card ID is required to register under this category.");
                    return;
                }

                if (!Regex.IsMatch(input, @"^JKM\d+$"))
                {
                    CustomMessageBox.Show("JKM Card ID must start with 'JKM' followed by numbers (e.g. JKM12345).");
                    return;
                }

                JKMCardId = input;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }
    }
}