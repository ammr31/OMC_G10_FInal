using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class DailyNeedsPage : Form
    {
        private FlowLayoutPanel flowProducts;
        private List<ProductCard> cards = new List<ProductCard>();

        public DailyNeedsPage()
        {
            InitializeComponent();
        }

        private void DailyNeedsPage_Load(object sender, EventArgs e)
        {
            flowProducts = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,  // stack top to bottom
                WrapContents = false,                    // no wrapping into columns
                BackColor = ColorTranslator.FromHtml("#6B7A52"),
                Padding = new Padding(20)
            };

            this.Controls.Add(flowProducts);
            flowProducts.BringToFront();



            LoadProducts();
        }



        private void LoadProducts()
        {
            List<Product> products = GetProductsFromDatabase();

            flowProducts.Controls.Clear();
            cards.Clear();

            int usableWidth = flowProducts.ClientSize.Width - flowProducts.Padding.Horizontal - 25;

            foreach (var product in products)
            {
                var card = new ProductCard();
                card.SetProduct(product); // not card.SetProduct(product.Name, product.Price, product.ImagePath)
                                          // card.AddToCartClicked += (s, e) => AddToCart(product);
                card.CardClicked += (s, clickedProduct) =>
                {
                    ProductDetailPage detailPage = new ProductDetailPage(clickedProduct, this);
                    detailPage.Show();
                    this.Hide();
                };

                flowProducts.Controls.Add(card);
                cards.Add(card);
            }
        }

        private void AddToCart(Product product)
        {
            MessageBox.Show($"{product.Name} added to cart!");
        }

        private List<Product> GetProductsFromDatabase()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Milk 1L", Price = 3.50m, ImagePath = "", Category = "DailyNeeds" },
                new Product { Id = 2, Name = "Bread Loaf", Price = 2.20m, ImagePath = "", Category = "DailyNeeds" },
                new Product { Id = 3, Name = "Eggs (12pc)", Price = 4.00m, ImagePath = "", Category = "DailyNeeds" },
                new Product { Id = 4, Name = "Rice 5kg", Price = 12.90m, ImagePath = "", Category = "DailyNeeds" },
                new Product { Id = 5, Name = "Cooking Oil 1L", Price = 6.50m, ImagePath = "", Category = "DailyNeeds" },
                new Product { Id = 6, Name = "Sugar 1kg", Price = 2.80m, ImagePath = "", Category = "DailyNeeds" }
            };

            return products;
        }
    }
}