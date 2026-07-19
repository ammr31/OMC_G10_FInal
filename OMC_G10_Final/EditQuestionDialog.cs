using System;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class EditQuestionDialog : Form
    {
        private TextBox txtQuestion;
        private TextBox txtCategory;
        private TextBox txtAnswer;

        public string UpdatedQuestion => txtQuestion.Text.Trim();
        public string UpdatedCategory => txtCategory.Text.Trim();
        public string UpdatedAnswer => txtAnswer.Text.Trim();

        public EditQuestionDialog(string question, string category, string answer)
        {
            this.Text = "Edit FAQ Question";
            this.BackColor = Color.FromArgb(108, 117, 82);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(500, 400);

            Label lblQ = new Label { Text = "Question:", ForeColor = Color.White, Location = new Point(20, 20), AutoSize = true, Font = new Font("Verdana", 9, FontStyle.Bold) };
            txtQuestion = new TextBox { Text = question, Location = new Point(20, 45), Width = 440 };

            Label lblC = new Label { Text = "Category:", ForeColor = Color.White, Location = new Point(20, 80), AutoSize = true, Font = new Font("Verdana", 9, FontStyle.Bold) };
            txtCategory = new TextBox { Text = category, Location = new Point(20, 105), Width = 440 };

            Label lblA = new Label { Text = "Answer:", ForeColor = Color.White, Location = new Point(20, 140), AutoSize = true, Font = new Font("Verdana", 9, FontStyle.Bold) };
            txtAnswer = new TextBox { Text = answer, Location = new Point(20, 165), Width = 440, Height = 120, Multiline = true, ScrollBars = ScrollBars.Vertical };

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

            this.Controls.Add(lblQ);
            this.Controls.Add(txtQuestion);
            this.Controls.Add(lblC);
            this.Controls.Add(txtCategory);
            this.Controls.Add(lblA);
            this.Controls.Add(txtAnswer);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }
    }
}