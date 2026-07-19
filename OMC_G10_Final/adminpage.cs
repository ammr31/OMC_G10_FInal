using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class adminpage : Form
    {
        private FlowLayoutPanel flowSuppliers;
        private List<SupplierTableRow> supplierRows = new List<SupplierTableRow>();

        public adminpage()
        {
            InitializeComponent();
        }


        private void SetupPanel()
        {
            flowSuppliers = new FlowLayoutPanel
            {
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = ColorTranslator.FromHtml("#6B7A52"),
                Padding = new Padding(0)
            };

            // Instead of Dock = Fill, manually position it below the header row.
            // Adjust the Y value (e.g. 240) to match wherever your column-name row's bottom edge is.
            flowSuppliers.Location = new Point(11, 344);
            flowSuppliers.Size = new Size(this.ClientSize.Width - 11, this.ClientSize.Height - 344);
            flowSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.Controls.Add(flowSuppliers);
            flowSuppliers.BringToFront();
            pageHeader1.BringToFront();

            // If your header row (Partner's Name/Type/Location/Status/Action) is a Panel control
            // in the Designer, bring it to front too so it stays visible:
            // pnlColumnHeaders.BringToFront();
        }

        private void LoadSuppliers()
        {
            flowSuppliers.Controls.Clear();

            supplierRows = SupplierTableRow.LoadAllFromDatabase();

            foreach (var row in supplierRows)
            {
                flowSuppliers.Controls.Add(row);
            }
        }

        private void adminpage_Load_1(object sender, EventArgs e)
        {
            SetupPanel();
            LoadSuppliers();
        }

        private void buttonShadow1_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is RegistrationForm)
            {
                return;
            }
            RegistrationForm newForm = new RegistrationForm();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
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

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }

        private void buttonShadow2_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is ManageQuestionform)
            {
                return;
            }
            ManageQuestionform newForm = new ManageQuestionform();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }
    }
}