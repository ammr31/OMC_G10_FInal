using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class ProductDetailPage : Form
    {
        private Product product;
        private Form parentPage;

        public ProductDetailPage()
        {
            InitializeComponent();
        }

        public ProductDetailPage(Product product, Form parentPage = null) : this()
        {
            this.product = product;
            this.parentPage = parentPage;
        }

        private void ProductDetailPage_Load(object sender, EventArgs e)
        {
            if (product == null) return;

            productnamedisplay.Text = product.Name;
            productpricedisplay.Text = "RM " + product.Price.ToString("0.00");
            detailsdisplay.Text = product.Details;

            if (!string.IsNullOrEmpty(product.ImagePath))
            {
                string fileNameOnly = Path.GetFileName(product.ImagePath);
                string fullImagePath = Path.Combine(Application.StartupPath, "ProductImages", fileNameOnly);

                if (File.Exists(fullImagePath))
                {
                    try { pictureBox1.Image = Image.FromFile(fullImagePath); }
                    catch { pictureBox1.Image = null; }
                }
            }

            RecentlyViewed.Track(product);
            LoadCustomerReviews();
        }

        private void LoadCustomerReviews()
        {
            DataTable reviews = DatabaseHelper.GetReviewsByProduct(product.Id);

            Label lblTitle = new Label
            {
                Text = "Customer Review :",
                Font = new Font("Verdana", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(128, 64, 0),
                AutoSize = true,
                Location = new Point(15, 15)
            };
            reviewpanel.Controls.Add(lblTitle);

            if (reviews.Rows.Count == 0)
            {
                Label lblNone = new Label
                {
                    Text = "No reviews yet.",
                    Font = new Font("Verdana", 10),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Location = new Point(15, 55)
                };
                reviewpanel.Controls.Add(lblNone);
                return;
            }

            int y = 55;
            foreach (DataRow row in reviews.Rows)
            {
                string reviewerName = row["ReviewerName"] != DBNull.Value ? row["ReviewerName"].ToString() : "Anonymous";
                string reviewDate = Convert.ToDateTime(row["ReviewDate"]).ToString("dd MMM yyyy");

                Label lblHeader = new Label
                {
                    Text = $"{reviewerName}  —  ★ {row["Rating"]}/5  —  {reviewDate}",
                    Font = new Font("Verdana", 9, FontStyle.Bold),
                    ForeColor = Color.FromArgb(128, 64, 0),
                    AutoSize = true,
                    Location = new Point(15, y)
                };
                reviewpanel.Controls.Add(lblHeader);
                y += lblHeader.Height + 5;

                Label lblText = new Label
                {
                    Text = row["ReviewText"].ToString(),
                    Font = new Font("Verdana", 10),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    MaximumSize = new Size(reviewpanel.Width - 40, 0),
                    Location = new Point(15, y)
                };
                reviewpanel.Controls.Add(lblText);

                y += lblText.Height + 20; // extra gap between reviews
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            if (parentPage != null)
                parentPage.Show();

            this.Close();
        }

        private void btnaddtocart_Click_1(object sender, EventArgs e)
        {
            if (product == null) return;

            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                MessageBox.Show("Please log in to add items to your cart.");
                return;
            }

            bool success = DatabaseHelper.AddToCart(
                Session.CurrentUserId, product.Id, product.Name, product.Price, 1);

            if (success)
                MessageBox.Show($"{product.Name} added to cart!");
            else
                MessageBox.Show("Failed to add to cart.");
        }
    }
}