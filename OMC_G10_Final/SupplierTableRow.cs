using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class SupplierTableRow : UserControl
    {
        private string supplierId;

        public event EventHandler<string> SupplierDeleted;

        public SupplierTableRow()
        {
            InitializeComponent();

            // Replace btnedit with your actual confirmed control name
            btnedit.Click += (s, e) => EditSupplier();
            btnedit.Cursor = Cursors.Hand;
        }

        public void SetSupplier(string id, string name, string type, string location, string status)
        {
            supplierId = id;
            PartnersNameDisplay.Text = name;
            Partnertypedisplay.Text = type;
            partnerlocationdisplay.Text = location;
            partnerstatusdisplay.Text = status;
        }

        public static List<SupplierTableRow> LoadAllFromDatabase()
        {
            List<SupplierTableRow> rows = new List<SupplierTableRow>();
            DataTable table = DatabaseHelper.GetAllSuppliers();

            foreach (DataRow row in table.Rows)
            {
                var supplierRow = new SupplierTableRow();
                supplierRow.SetSupplier(
                    row["SupplierID"].ToString(),
                    row["BusinessName"].ToString(),
                    row["Type"].ToString(),
                    row["BusinessAddress"].ToString(),
                    row["Status"].ToString()
                );

                rows.Add(supplierRow);
            }

            return rows;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(supplierId)) return;

            DialogResult confirm = MessageBox.Show(
                $"Delete supplier {supplierId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            bool success = DatabaseHelper.DeleteSupplier(supplierId);

            if (success)
            {
                MessageBox.Show("Supplier deleted.");

                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }

                SupplierDeleted?.Invoke(this, supplierId);
            }
            else
            {
                MessageBox.Show("Failed to delete supplier.");
            }
        }

        private void EditSupplier()
        {
            using (EditSupplierDialog dialog = new EditSupplierDialog(
                PartnersNameDisplay.Text, Partnertypedisplay.Text, partnerlocationdisplay.Text, partnerstatusdisplay.Text))
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool success = DatabaseHelper.UpdateSupplier(
                        supplierId,
                        dialog.UpdatedBusinessName,
                        dialog.UpdatedType,
                        dialog.UpdatedAddress,
                        dialog.UpdatedStatus);

                    if (success)
                    {
                        PartnersNameDisplay.Text = dialog.UpdatedBusinessName;
                        Partnertypedisplay.Text = dialog.UpdatedType;
                        partnerlocationdisplay.Text = dialog.UpdatedAddress;
                        partnerstatusdisplay.Text = dialog.UpdatedStatus;

                        MessageBox.Show("Supplier updated.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update supplier.");
                    }
                }
            }
        }
    }
}