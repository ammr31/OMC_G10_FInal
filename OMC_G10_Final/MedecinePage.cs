using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class MedecinePage : Form
    {
        private FlowLayoutPanel flowProducts;
        private List<ProductCard> cards = new List<ProductCard>();

        public MedecinePage()
        {
            InitializeComponent();
        }

        private void MedecinePage_Load(object sender, EventArgs e)
        {
            flowProducts = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = ColorTranslator.FromHtml("#6B7A52"),
                Padding = new Padding(20)
            };

            this.Controls.Add(flowProducts);
            flowProducts.BringToFront();


            LoadProducts();
        }
        private void ResizeAllCards()
        {
            int usableWidth = flowProducts.ClientSize.Width - flowProducts.Padding.Horizontal - 25;
            foreach (var card in cards) ;
        }

        private void LoadProducts()
        {
            List<Product> products = GetMedicineFromDatabase();

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

        private List<Product> GetMedicineFromDatabase()
        {
            // TODO: replace with real query, e.g.:
            // SELECT Id, Name, Price, ImagePath FROM Medicine
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Paracetamol 500mg", Price = 5.90m, ImagePath = "",Category = "Medicine"  },
                new Product { Id = 2, Name = "Cough Syrup 100ml", Price = 8.50m, ImagePath = "",Category = "Medicine"  },
                new Product { Id = 3, Name = "Rechargeable Hearing Aids", Price = 49.99m, ImagePath = "",Category = "Medicine"  },
                new Product { Id = 4, Name = "Hearing Aids Auxiliary Headphones", Price = 31.90m, ImagePath = "",Category = "Medicine"  }
            };

            return products;
        }
    }
}

