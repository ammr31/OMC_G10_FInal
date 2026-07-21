using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
                card.SetProduct(product);
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
            var products = new List<Product>();

            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT ProductID, ProductName, PriceRM, ImagePath, CategoryName, [Details], AccessibilityName FROM Products WHERE CategoryName = ?";

                    if (!string.IsNullOrEmpty(Session.AccessibilityFilter))
                    {
                        query += " AND AccessibilityName = ?";
                    }

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", "Medicine");

                        if (!string.IsNullOrEmpty(Session.AccessibilityFilter))
                        {
                            cmd.Parameters.AddWithValue("@AccessibilityName", Session.AccessibilityFilter);
                        }

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new Product
                                {
                                    Id = reader["ProductID"].ToString(),
                                    Name = reader["ProductName"].ToString(),
                                    Price = Convert.ToDecimal(reader["PriceRM"]),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    Category = reader["CategoryName"].ToString(),
                                    Details = reader["Details"].ToString(),
                                    AccessibilityName = reader["AccessibilityName"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading medicine products: {ex.Message}");
                }
            }

            return products;
        }
    }
}