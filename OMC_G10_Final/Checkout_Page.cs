using AntdUI;
using System;
using System.Data;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class Checkout_Page : Form
    {
        private DataTable cartItems;
        private decimal subtotal;
        private decimal shipping;
        private decimal total;

        public Checkout_Page(DataTable cartItems, decimal subtotal, decimal shipping, decimal total)
        {
            InitializeComponent();
            this.cartItems = cartItems;
            this.subtotal = subtotal;
            this.shipping = shipping;
            this.total = total;
        }



        private void ToggleCardDetails()
        {
            bool showCardFields = rdcard.Checked;

            txtcardnumber.Enabled = showCardFields;
            txtnameoncard.Enabled = showCardFields;
            DPexpirydate.Enabled = showCardFields;
            txtCW.Enabled = showCardFields;
            checkbox1.Enabled = showCardFields;
        }



        private void Checkout_Page_Load_1(object sender, EventArgs e)
        {
            Subtotaldisplay.Text = "RM " + subtotal.ToString("0.00");
            Shippingtotaldisplay.Text = "RM " + shipping.ToString("0.00");
            Totaldisplay.Text = "RM " + total.ToString("0.00");

            ToggleCardDetails();

            rdcard.CheckedChanged += (s, e2) => ToggleCardDetails();
            rdewallet.CheckedChanged += (s, e2) => ToggleCardDetails();
            rdonlinebanking.CheckedChanged += (s, e2) => ToggleCardDetails();
            rdcod.CheckedChanged += (s, e2) => ToggleCardDetails();
        }

        private void btnproceed_Click_1(object sender, EventArgs e)
        {
            string paymentMethod = rdcard.Checked ? "Credit / Debit Card" :
                            rdonlinebanking.Checked ? "FPX Online Banking" :
                            rdewallet.Checked ? "E-Wallet" :
                            rdcod.Checked ? "Cash on Delivery" : "";

            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            if (paymentMethod == "Credit / Debit Card")
            {
                if (string.IsNullOrEmpty(txtcardnumber.Text) ||
                    string.IsNullOrEmpty(txtnameoncard.Text) ||
                    string.IsNullOrEmpty(txtCW.Text))
                {
                    MessageBox.Show("Please fill in all card details.");
                    return;
                }

                CompleteOrder(paymentMethod);
            }
            else if (paymentMethod == "FPX Online Banking" || paymentMethod == "E-Wallet")
            {
                using (QRPaymentForm qrForm = new QRPaymentForm(paymentMethod, total))
                {
                    DialogResult result = qrForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        CompleteOrder(paymentMethod);
                    }
                }
            }
            else // Cash on Delivery
            {
                CompleteOrder(paymentMethod);
            }
        }

        private void CompleteOrder(string paymentMethod)
        {
            string orderId = DatabaseHelper.CreateOrder(
                Session.CurrentUserId, cartItems, subtotal, shipping, total, paymentMethod);

            if (!string.IsNullOrEmpty(orderId))
            {
                DatabaseHelper.ClearCheckedOutItems(Session.CurrentUserId);

                PaymentSuccessPage successPage = new PaymentSuccessPage(orderId);
                successPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to place order.");
            }
        }

        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is CartPage)
            {
                return;
            }
            // Open the Mobility Form
            CartPage newForm = new CartPage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }
    }
}