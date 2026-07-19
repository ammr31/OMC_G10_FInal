using System;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class EditSupplierDialog : Form
    {
        private TextBox txtBusinessName;
        private TextBox txtType;
        private TextBox txtAddress;
        private ComboBox cmbStatus;

        public string UpdatedBusinessName => txtBusinessName.Text.Trim();
        public string UpdatedType => txtType.Text.Trim();
        public string UpdatedAddress => txtAddress.Text.Trim();
        public string UpdatedStatus => cmbStatus.Text.Trim();

        public EditSupplierDialog(string businessName, string type, string address, string status)
        {
            this.Text = "Edit Supplier";
            this.BackColor = Color.FromArgb(108, 117, 82);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(500, 400);

            Label lblName = new Label { Text = "Business Name:", ForeColor = Color.White, Location = new Point(20, 20), AutoSize = true, Font = new Font("Verdana", 9, FontStyle.Bold) };
            txtBusinessName = new TextBox { Text = businessName, Location = new Point(20, 45), Width = 440 };

            Label lblType = new Label { Text = "Type:", ForeColor = Color.White, Location = new Point(20, 80), AutoSize = true, Font = new Font("Verdana", 9, FontStyle.Bold) };
            txtType = new TextBox { Text = type, Location = new Point(20, 105), Width = 440 };

            Label lblAddress = new Label { Text = "Location:", ForeColor = Color.White, Location = new Point(20, 140), AutoSize = true, Font = new Font("Verdana", 9, FontStyle.Bold) };
            txtAddress = new TextBox { Text = address, Location = new Point(20, 165), Width = 440, Height = 60, Multiline = true, ScrollBars = ScrollBars.Vertical };

            Label lblStatus = new Label { Text = "Status:", ForeColor = Color.White, Location = new Point(20, 235), AutoSize = true, Font = new Font("Verdana", 9, FontStyle.Bold) };
            cmbStatus = new ComboBox { Location = new Point(20, 260), Width = 440, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.SelectedItem = status;
            if (cmbStatus.SelectedIndex < 0) cmbStatus.SelectedIndex = 0;

            Button btnSave = new Button
            {
                Text = "Save",
                DialogResult = DialogResult.OK,
                Size = new Size(100, 35),
                Location = new Point(180, 310),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(108, 117, 82),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Verdana", 9, FontStyle.Bold)
            };
            btnSave.FlatAppearance.BorderSize = 0;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Size = new Size(100, 35),
                Location = new Point(290, 310),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(108, 117, 82),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Verdana", 9, FontStyle.Bold)
            };
            btnCancel.FlatAppearance.BorderSize = 0;

            this.Controls.Add(lblName);
            this.Controls.Add(txtBusinessName);
            this.Controls.Add(lblType);
            this.Controls.Add(txtType);
            this.Controls.Add(lblAddress);
            this.Controls.Add(txtAddress);
            this.Controls.Add(lblStatus);
            this.Controls.Add(cmbStatus);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }
    }
}
