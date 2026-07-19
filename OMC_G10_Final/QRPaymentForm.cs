using System;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class QRPaymentForm : Form
    {
        public QRPaymentForm(string paymentMethod, decimal total)
        {
            this.Text = "Scan to Pay";
            this.BackColor = Color.FromArgb(108, 117, 82);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(400, 500);

            Label lblTitle = new Label
            {
                Text = paymentMethod,
                Font = new Font("Verdana", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 20)
            };

            PictureBox qrBox = new PictureBox
            {
                Size = new Size(250, 250),
                Location = new Point(65, 70),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            qrBox.Paint += (s, e) => DrawFakeQR(e.Graphics, qrBox.ClientRectangle);

            Label lblAmount = new Label
            {
                Text = "Amount: RM " + total.ToString("0.00"),
                Font = new Font("Verdana", 11, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(100, 335)
            };

            Button btnNext = new Button
            {
                Text = "NEXT",
                Font = new Font("Verdana", 12, FontStyle.Bold),
                Size = new Size(200, 45),
                Location = new Point(100, 390),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(108, 117, 82),
                FlatStyle = FlatStyle.Flat,
                DialogResult = DialogResult.OK
            };
            btnNext.FlatAppearance.BorderSize = 0;

            this.Controls.Add(lblTitle);
            this.Controls.Add(qrBox);
            this.Controls.Add(lblAmount);
            this.Controls.Add(btnNext);

            this.AcceptButton = btnNext;
        }

        private void DrawFakeQR(Graphics g, Rectangle bounds)
        {
            Random rnd = new Random(42);
            int cellSize = 15;
            int cols = bounds.Width / cellSize;
            int rows = bounds.Height / cellSize;

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (rnd.Next(2) == 0)
                        g.FillRectangle(Brushes.Black, x * cellSize, y * cellSize, cellSize, cellSize);
                }
            }

            DrawCornerMarker(g, 0, 0, cellSize);
            DrawCornerMarker(g, bounds.Width - cellSize * 5, 0, cellSize);
            DrawCornerMarker(g, 0, bounds.Height - cellSize * 5, cellSize);
        }

        private void DrawCornerMarker(Graphics g, int x, int y, int cellSize)
        {
            g.FillRectangle(Brushes.White, x, y, cellSize * 5, cellSize * 5);
            g.FillRectangle(Brushes.Black, x, y, cellSize * 5, cellSize * 5);
            g.FillRectangle(Brushes.White, x + cellSize, y + cellSize, cellSize * 3, cellSize * 3);
            g.FillRectangle(Brushes.Black, x + cellSize * 2, y + cellSize * 2, cellSize, cellSize);
        }
    }
}