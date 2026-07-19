using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class PaymentSuccessPage : Form
    {
        private string orderId;

        public PaymentSuccessPage(string orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void PaymentSuccessPage_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();

            btnyes.Click += btnyes_Click;
            btnlater.Click += btnlater_Click;
        }

        private void LoadOrderDetails()
        {
            DataRow order = DatabaseHelper.GetOrderById(orderId);
            if (order == null)
            {
                MessageBox.Show("Order not found.");
                return;
            }

            // ORDER DETAILS PANEL
            Label lblOrderId = new Label
            {
                Text = "Order ID: " + order["OrderID"].ToString(),
                ForeColor = Color.White,
                Font = new Font("Verdana", 10),
                AutoSize = true,
                Location = new Point(20, 60)
            };

            Label lblOrderDate = new Label
            {
                Text = "Order Date: " + Convert.ToDateTime(order["OrderDate"]).ToString("dd MMMM yyyy"),
                ForeColor = Color.White,
                Font = new Font("Verdana", 10),
                AutoSize = true,
                Location = new Point(20, 90)
            };

            orderdetailspanel.Controls.Add(lblOrderId);
            orderdetailspanel.Controls.Add(lblOrderDate);

            // DELIVERY STATUS PANEL
            Label lblStatusDot = new Label
            {
                Text = "●",
                ForeColor = Color.FromArgb(76, 175, 80),
                Font = new Font("Segoe UI", 14),
                AutoSize = true,
                Location = new Point(20, 60)
            };

            Label lblStatus = new Label
            {
                Text = order["DeliveryStatus"].ToString(),
                ForeColor = Color.White,
                Font = new Font("Verdana", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(45, 58)
            };

            Label lblArrival = new Label
            {
                Text = "Estimated Arrival:\n" + Convert.ToDateTime(order["EstimatedArrival"]).ToString("dd MMMM yyyy"),
                ForeColor = Color.White,
                Font = new Font("Verdana", 10),
                AutoSize = true,
                Location = new Point(20, 95)
            };

            deliverystatuspanel.Controls.Add(lblStatusDot);
            deliverystatuspanel.Controls.Add(lblStatus);
            deliverystatuspanel.Controls.Add(lblArrival);

            // ITEMS ORDERED PANEL
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            DataTable items = DatabaseHelper.GetOrderItemsByOrderId(orderId);

            Label lblProductHeader = new Label
            {
                Text = "Product",
                ForeColor = Color.White,
                Font = new Font("Verdana", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 60)
            };

            Label lblQtyHeader = new Label
            {
                Text = "Qty",
                ForeColor = Color.White,
                Font = new Font("Verdana", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(itemsorderdpanel.Width - 60, 60)
            };

            itemsorderdpanel.Controls.Add(lblProductHeader);
            itemsorderdpanel.Controls.Add(lblQtyHeader);

            int itemY = 90;
            foreach (DataRow item in items.Rows)
            {
                Label lblProduct = new Label
                {
                    Text = item["ProductName"].ToString(),
                    ForeColor = Color.White,
                    Font = new Font("Verdana", 10),
                    AutoSize = true,
                    Location = new Point(20, itemY),
                    MaximumSize = new Size(itemsorderdpanel.Width - 100, 0)
                };

                Label lblQty = new Label
                {
                    Text = item["Quantity"].ToString(),
                    ForeColor = Color.White,
                    Font = new Font("Verdana", 10),
                    AutoSize = true,
                    Location = new Point(itemsorderdpanel.Width - 60, itemY)
                };

                itemsorderdpanel.Controls.Add(lblProduct);
                itemsorderdpanel.Controls.Add(lblQty);

                itemY += Math.Max(lblProduct.Height, 25) + 10;
            }
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            ProfilePage profile = new ProfilePage();
            profile.Show();
            this.Close();
        }

        private void btnlater_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }
    }
}