using System;
using System.IO;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class ProductDetailPage : Form
    {
        private Product product;
        private Form parentPage; // the page that opened this detail page

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

            productnamedisplay.Text = product.Name;      // rename to match your actual controls
            productpricedisplay.Text = product.Price.ToString("C");

            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
                pictureBox1.Image = Image.FromFile(product.ImagePath);

            RecentlyViewed.Track(product);
        }


        private void btnback_Click_1(object sender, EventArgs e)
        {
            if (parentPage != null)
                parentPage.Show(); // bring the previous page back

            this.Close(); // close this detail page
        }

        private void btnaddtocart_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"{product.Name} added to cart!");

        }
    }
}