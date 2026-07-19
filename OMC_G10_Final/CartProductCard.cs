using System;
using System.IO;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class CartProductCard : UserControl
    {
        private string cartId;
        private int currentQuantity;

        public event EventHandler CartUpdated;

        public CartProductCard()
        {
            InitializeComponent();

            btnplus.Click += (s, e) => ChangeQuantity(1);
            btnminus.Click += (s, e) => ChangeQuantity(-1);
            btndelete.Click += (s, e) => DeleteItem();
            itemselect.CheckedChanged += (s, e) => ToggleSelection();
        }

        public void SetCartItem(string cartId, string productName, decimal price, int quantity, string imagePath, bool isSelected)
        {
            this.cartId = cartId;
            this.currentQuantity = quantity;

            productnamedisplay.Text = productName;
            productpricedisplay.Text = "RM " + price.ToString("0.00");
            numberdisplay.Text = quantity.ToString();
            itemselect.Checked = isSelected;

            if (!string.IsNullOrEmpty(imagePath))
            {
                string fileNameOnly = Path.GetFileName(imagePath);
                string fullPath = Path.Combine(Application.StartupPath, "ProductImages", fileNameOnly);

                if (File.Exists(fullPath))
                {
                    try { pictureBox1.Image = System.Drawing.Image.FromFile(fullPath); }
                    catch { pictureBox1.Image = null; }
                }
            }
        }

        private void ChangeQuantity(int delta)
        {
            int newQuantity = currentQuantity + delta;
            if (newQuantity < 1) return; // use Delete instead of going to 0

            bool success = DatabaseHelper.UpdateCartQuantity(cartId, newQuantity);
            if (success)
            {
                currentQuantity = newQuantity;
                numberdisplay.Text = currentQuantity.ToString();
                CartUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        private void DeleteItem()
        {
            DialogResult confirm = MessageBox.Show("Remove this item from cart?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            bool success = DatabaseHelper.RemoveFromCart(cartId);
            if (success)
            {
                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }
                CartUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ToggleSelection()
        {
            DatabaseHelper.UpdateCartSelection(cartId, itemselect.Checked);
            CartUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}