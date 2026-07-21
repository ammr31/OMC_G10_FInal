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
        private Dictionary<string, string> accessibilityMap = new Dictionary<string, string>();
        private string selectedImagePath = ""; // stores the filename saved into ProductImages

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

        private void LoadAccessibility()
        {
            slctAccessibility.Items.Clear();
            accessibilityMap = DatabaseHelper.GetAccessibilityNameToIdMap();

            foreach (string accessibilityName in accessibilityMap.Keys)
            {
                slctAccessibility.Items.Add(accessibilityName);
            }
        }

        private void LoadSupplierProducts()
        {
            slctproduct.Items.Clear();

            if (string.IsNullOrEmpty(Session.CurrentUserId)) return;

            List<string> products = DatabaseHelper.GetProductNamesBySupplier(Session.CurrentUserId);

            foreach (string name in products)
            {
                slctproduct.Items.Add(name);
            }
        }

        private void SupplierPage_Load_1(object sender, EventArgs e)
        {
            LoadCategories();
            LoadAccessibility();
            LoadSupplierProducts();
        }

        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is ProfilePage)
            {
                return;
            }
            ProfilePage newForm = new ProfilePage();
            newForm.Show();
            this.Hide();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Select Product Image";
                openDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourcePath = openDialog.FileName;
                        string fileName = Path.GetFileName(sourcePath);

                        string destFolder = Path.Combine(Application.StartupPath, "ProductImages");
                        if (!Directory.Exists(destFolder))
                            Directory.CreateDirectory(destFolder);

                        string destPath = Path.Combine(destFolder, fileName);

                        // Avoid overwriting a different image that happens to share the same filename
                        if (File.Exists(destPath) && sourcePath != destPath)
                        {
                            string uniqueName = Guid.NewGuid().ToString("N").Substring(0, 8) + "_" + fileName;
                            destPath = Path.Combine(destFolder, uniqueName);
                            fileName = uniqueName;
                        }

                        if (sourcePath != destPath)
                            File.Copy(sourcePath, destPath, overwrite: false);

                        selectedImagePath = fileName;
                        btnbrowse.Text = fileName; // show the chosen filename right on the button
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show($"Error selecting image: {ex.Message}");
                    }
                }
            }
        }



        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                CustomMessageBox.Show("You must be logged in as a supplier.");
                return;
            }

            string productName = txtproductname.Text?.Trim() ?? "";
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

            if (slctAccessibility.SelectedIndex < 0 || slctAccessibility.SelectedIndex >= slctAccessibility.Items.Count)
            {
                CustomMessageBox.Show("Please choose an accessibility type.");
                return;
            }

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                CustomMessageBox.Show("Please select a product image.");
                return;
            }

            string categoryName = slctCategory.Items[slctCategory.SelectedIndex].ToString();
            string categoryId = categoryMap.ContainsKey(categoryName) ? categoryMap[categoryName] : "";

            string accessibilityName = slctAccessibility.Items[slctAccessibility.SelectedIndex].ToString();
            string accessibilityId = accessibilityMap.ContainsKey(accessibilityName) ? accessibilityMap[accessibilityName] : "";

            bool success = DatabaseHelper.AddNewProduct(
                Session.CurrentUserId, productName, selectedImagePath, price, details, quantity,
                categoryId, categoryName, accessibilityId, accessibilityName);

            if (success)
            {
                CustomMessageBox.Show("Product added successfully.");
                txtproductname.Clear();
                txtproductprice.Clear();
                txtproductdetails.Clear();
                txtQuantityAdd.Text = "";
                slctCategory.SelectedIndex = -1;
                slctAccessibility.SelectedIndex = -1;
                selectedImagePath = "";
                btnbrowse.Text = "Browse"; // reset button label
                LoadSupplierProducts();
            }
            else
            {
                CustomMessageBox.Show("Failed to add product.");
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.CurrentUserId))
            {
                CustomMessageBox.Show("You must be logged in as a supplier.");
                return;
            }

            if (slctproduct.SelectedIndex < 0 || slctproduct.SelectedIndex >= slctproduct.Items.Count)
            {
                CustomMessageBox.Show("Please choose a product to restock.");
                return;
            }

            string productName = slctproduct.Items[slctproduct.SelectedIndex].ToString();
            string restockQuantityText = txtquantityrestock.Text?.Trim() ?? "";

            if (!int.TryParse(restockQuantityText, out int addQuantity) || addQuantity <= 0)
            {
                CustomMessageBox.Show("Please enter a quantity greater than 0.");
                return;
            }

            bool success = DatabaseHelper.RestockProduct(productName, Session.CurrentUserId, addQuantity);

            if (success)
            {
                CustomMessageBox.Show("Product restocked successfully.");
                txtquantityrestock.Text = "";
                slctproduct.SelectedIndex = -1;
            }
            else
            {
                CustomMessageBox.Show("Failed to restock product.");
            }
        }
    }
}