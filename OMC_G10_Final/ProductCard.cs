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
            productpricedisplay.Text = product.Price.ToString("C");

            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
                pictureBox1.Image = Image.FromFile(product.ImagePath);

            this.Cursor = Cursors.Hand;
        }

        public void SetCardWidth(int totalWidth)
        {
            this.Width = totalWidth;
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
                MessageBox.Show($"{currentProduct.Name} added to cart!");

            AddToCartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}