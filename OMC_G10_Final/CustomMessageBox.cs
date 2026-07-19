using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
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
}