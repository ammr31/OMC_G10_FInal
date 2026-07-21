using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class ProductCard : UserControl
    {
        private Product currentProduct;

        public event EventHandler<Product> CardClicked;
        public event EventHandler AddToCartClicked;

        public ProductCard()
        {
            InitializeComponent();
            WireClickRecursive(this);
        }

        private void WireClickRecursive(Control control)
        {
            control.Click += Card_Click;
            foreach (Control child in control.Controls)
            {
                if (child == btnaddtocart) continue; // don't hijack the Add to Cart button
                WireClickRecursive(child);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
                CardClicked?.Invoke(this, currentProduct);
            // No navigation here — the parent page (DailyNeedsPage, MedicinePage, RecentPage)
            // already listens to CardClicked and opens ProductDetailPage with the correct product.
        }

        public void SetProduct(Product product)
        {
            currentProduct = product;
            productnamedisplay.Text = product.Name;
            productpricedisplay.Text = "RM " + product.Price.ToString("0.00");
            detailsdisplay.Text = product.Details;

            if (!string.IsNullOrEmpty(product.ImagePath))
            {
                // Take only the filename, regardless of what's stored in the database
                string fileNameOnly = Path.GetFileName(product.ImagePath);
                string fullImagePath = Path.Combine(Application.StartupPath, "ProductImages", fileNameOnly);

                if (File.Exists(fullImagePath))
                    pictureBox1.Image = Image.FromFile(fullImagePath);
            }
            this.Cursor = Cursors.Hand;
        }

        public void SetCardWidth(int totalWidth)
        {
            this.Width = totalWidth;
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                if (string.IsNullOrEmpty(Session.CurrentUserId))
                {
                    MessageBox.Show("Please log in to add items to your cart.");
                    return;
                }

                bool success = DatabaseHelper.AddToCart(
                    Session.CurrentUserId,
                    currentProduct.Id,
                    currentProduct.Name,
                    currentProduct.Price,
                    1);

                if (success)
                    MessageBox.Show($"{currentProduct.Name} added to cart!");
            }

            AddToCartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}