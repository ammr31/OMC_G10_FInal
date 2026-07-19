using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class SupplierPage : Form
    {
        private Dictionary<string, string> categoryMap = new Dictionary<string, string>();

        public SupplierPage()
        {
            InitializeComponent();
        }


        private void LoadCategories()
        {
            slctCategory.Items.Clear();
            categoryMap = DatabaseHelper.GetCategoryNameToIdMap();

            foreach (string categoryName in categoryMap.Keys)
            {
                slctCategory.Items.Add(categoryName);
            }
        }

        private void LoadSupplierProducts()
        {
            cmbChooseProduct.Items.Clear();

            if (string.IsNullOrEmpty(Session.CurrentUserId)) return;

            List<string> products = DatabaseHelper.GetProductNamesBySupplier(Session.CurrentUserId);

            foreach (string name in products)
            {
                cmbChooseProduct.Items.Add(name);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                CustomMessageBox.Show("You must be logged in as a supplier.");
                return;
            }

            string productName = txtproductname.Text?.Trim() ?? "";
            string imagePath = txtproductimage.Text?.Trim() ?? "";
            string priceText = txtproductprice.Text?.Trim() ?? "";
            string details = txtproductdetails.Text?.Trim() ?? "";
            string quantityText = txtQuantityAdd.Text?.Trim() ?? "";

            if (!int.TryParse(quantityText, out int quantity))
            {
                CustomMessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(priceText))
            {
                CustomMessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                CustomMessageBox.Show("Please enter a valid price.");
                return;
            }

            if (slctCategory.SelectedIndex < 0 || slctCategory.SelectedIndex >= slctCategory.Items.Count)
            {
                CustomMessageBox.Show("Please choose a category.");
                return;
            }

            string categoryName = slctCategory.Items[slctCategory.SelectedIndex].ToString();
            string categoryId = categoryMap.ContainsKey(categoryName) ? categoryMap[categoryName] : "";

            bool success = DatabaseHelper.AddNewProduct(
                Session.CurrentUserId, productName, imagePath, price, details, quantity, categoryId, categoryName);

            if (success)
            {
                CustomMessageBox.Show("Product added successfully.");
                txtproductname.Clear();
                txtproductimage.Clear();
                txtproductprice.Clear();
                txtproductdetails.Clear();
                txtQuantityAdd.Text = "";
                slctCategory.SelectedIndex = -1;
                LoadSupplierProducts();
            }
            else
            {
                CustomMessageBox.Show("Failed to add product.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                CustomMessageBox.Show("You must be logged in as a supplier.");
                return;
            }

            if (cmbChooseProduct.SelectedIndex == null)
            {
                CustomMessageBox.Show("Please choose a product to restock.");
                return;
            }

            string productName = cmbChooseProduct.SelectedIndex.ToString();
            string restockQuantityText = txtquantityrestock.Text?.Trim() ?? "";

            if (!int.TryParse(restockQuantityText, out int addQuantity) || addQuantity <= 0)
            {
                CustomMessageBox.Show("Please enter a quantity greater than 0.");
                return;
            }
            if (addQuantity <= 0)
            {
                CustomMessageBox.Show("Please enter a quantity greater than 0.");
                return;
            }

            bool success = DatabaseHelper.RestockProduct(productName, Session.CurrentUserId, addQuantity);

            if (success)
            {
                CustomMessageBox.Show("Product restocked successfully.");
                txtquantityrestock.Text = "";
            }
            else
            {
                CustomMessageBox.Show("Failed to restock product.");
            }
        }

        private void SupplierPage_Load_1(object sender, EventArgs e)
        {
            LoadCategories();
            LoadSupplierProducts();
        }

        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is ProfilePage)
            {
                return;
            }
            // Open the Mobility Form
            ProfilePage newForm = new ProfilePage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }
    }
}