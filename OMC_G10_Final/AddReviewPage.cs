using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public class AddReviewPage : Form
    {
        private Product product;
        private string userId;
        private int selectedRating = 0;
        private Button[] starButtons;
        private TextBox txtReview;

        public AddReviewPage(Product product, string userId)
        {
            this.product = product;
            this.userId = userId;
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Write a Review";
            this.Size = new Size(420, 380);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(240, 240, 225);

            Label lblProduct = new Label
            {
                Text = product.Name,
                Font = new Font("Verdana", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(128, 64, 0),
                AutoSize = true,
                Location = new Point(20, 20)
            };
            this.Controls.Add(lblProduct);

            Label lblRating = new Label
            {
                Text = "Your Rating:",
                Font = new Font("Verdana", 10),
                AutoSize = true,
                Location = new Point(20, 60)
            };
            this.Controls.Add(lblRating);

            starButtons = new Button[5];
            for (int i = 0; i < 5; i++)
            {
                int starValue = i + 1;
                Button star = new Button
                {
                    Text = "☆",
                    Font = new Font("Segoe UI", 16),
                    Size = new Size(40, 40),
                    Location = new Point(20 + i * 45, 90),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.FromArgb(200, 150, 0)
                };
                star.FlatAppearance.BorderSize = 0;
                star.Click += (s, e) => SetRating(starValue);
                starButtons[i] = star;
                this.Controls.Add(star);
            }

            Label lblReview = new Label
            {
                Text = "Your Review:",
                Font = new Font("Verdana", 10),
                AutoSize = true,
                Location = new Point(20, 150)
            };
            this.Controls.Add(lblReview);

            txtReview = new TextBox
            {
                Multiline = true,
                Location = new Point(20, 175),
                Size = new Size(365, 100),
                Font = new Font("Verdana", 9)
            };
            this.Controls.Add(txtReview);

            Button btnSubmit = new Button
            {
                Text = "Submit Review",
                Size = new Size(140, 40),
                Location = new Point(20, 290),
                BackColor = Color.FromArgb(255, 200, 220),
                FlatStyle = FlatStyle.Flat
            };
            btnSubmit.Click += BtnSubmit_Click;
            this.Controls.Add(btnSubmit);

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Size = new Size(100, 40),
                Location = new Point(180, 290),
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            this.Controls.Add(btnCancel);
        }

        private void SetRating(int value)
        {
            selectedRating = value;
            for (int i = 0; i < starButtons.Length; i++)
                starButtons[i].Text = (i < value) ? "★" : "☆";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (selectedRating == 0)
            {
                CustomMessageBox.Show("Please select a star rating.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReview.Text))
            {
                CustomMessageBox.Show("Please write a short review.");
                return;
            }

            bool success = DatabaseHelper.AddReview(product.Id, userId, selectedRating, txtReview.Text.Trim());

            if (success)
            {
                CustomMessageBox.Show("Thanks for your review!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CustomMessageBox.Show("Failed to submit review.");
            }
        }
    }
}