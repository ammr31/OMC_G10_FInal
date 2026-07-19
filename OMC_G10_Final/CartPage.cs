using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class CartPage : Form
    {
        private FlowLayoutPanel flowCart;

        public CartPage()
        {
            InitializeComponent();
        }

        private void SetupPanel()
        {
            flowCart = new FlowLayoutPanel
            {
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = ColorTranslator.FromHtml("#6B7A52")
            };

            int bottomNavHeight = bottomNavigationBar1.Height; // use actual control height instead of guessing

            flowCart.Location = new Point(20, 130);
            flowCart.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 130 - (bottomNavHeight + 70));
            flowCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            flowCart.Resize += (s, e) => CenterCartItems();

            this.Controls.Add(flowCart);
            flowCart.BringToFront();
            bottomNavigationBar1.BringToFront();
        }

        private void LoadCartItems()
        {
            flowCart.Controls.Clear();

            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                MessageBox.Show("No user is logged in.");
                return;
            }

            DataTable table = DatabaseHelper.GetCartItemsByUser(Session.CurrentUserId);

            foreach (DataRow row in table.Rows)
            {
                var card = new CartProductCard();
                card.SetCartItem(
                    row["CartID"].ToString(),
                    row["ProductName"].ToString(),
                    Convert.ToDecimal(row["UnitPriceRM"]),
                    Convert.ToInt32(row["Quantity"]),
                    row["ImagePath"]?.ToString() ?? "",
                    Convert.ToBoolean(row["SelectedForCheckout"])
                );

                card.CartUpdated += (s, e) => LoadCartItems();

                flowCart.Controls.Add(card);
            }

            CenterCartItems();
        }

        private void CenterCartItems()
        {
            foreach (Control card in flowCart.Controls)
            {
                int leftMargin = Math.Max(0, (flowCart.ClientSize.Width - card.Width) / 2);
                card.Margin = new Padding(leftMargin, card.Margin.Top, 0, card.Margin.Bottom);
            }
        }

        private void CartPage_Load_1(object sender, EventArgs e)
        {
            SetupPanel();
            LoadCartItems();
        }

        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is MainPage)
            {
                return;
            }
            // Open the Mobility Form
            MainPage newForm = new MainPage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                MessageBox.Show("Please log in first.");
                return;
            }

            DataTable selectedItems = DatabaseHelper.GetSelectedCartItems(Session.CurrentUserId);

            if (selectedItems.Rows.Count == 0)
            {
                MessageBox.Show("Please select at least one item to checkout.");
                return;
            }

            decimal subtotal = 0;
            foreach (DataRow row in selectedItems.Rows)
            {
                subtotal += Convert.ToDecimal(row["LineTotalRM"]);
            }

            decimal shipping = 20.60m; // TODO: replace with real shipping calculation if you have one
            decimal total = subtotal + shipping;

            Checkout_Page checkoutForm = new Checkout_Page(selectedItems, subtotal, shipping, total);
            checkoutForm.Show();
            this.Hide();
        }
    }
}