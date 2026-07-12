using System;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class RecentPage : Form
    {
        private FlowLayoutPanel flowRecent;
        private bool isLoading = false; // reentrancy guard

        public RecentPage()
        {
            InitializeComponent();
        }

        private void RecentPage_Load(object sender, EventArgs e)
        {
            flowRecent = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = ColorTranslator.FromHtml("#6B7A52"),
                Padding = new Padding(20)
            };

            this.Controls.Add(flowRecent);
            flowRecent.BringToFront();

            // REMOVED: flowRecent.Resize += (s, e) => LoadRecentProducts();
            // that line was the cause of the duplicate bug

            LoadRecentProducts();
        }

        private void LoadRecentProducts()
        {
            if (isLoading) return; // block re-entrant calls
            isLoading = true;

            flowRecent.SuspendLayout(); // stop layout events firing mid-update
            flowRecent.Controls.Clear();

            if (RecentlyViewed.Items.Count == 0)
            {
                var lblEmpty = new Label
                {
                    Text = "No recently viewed items yet.",
                    Font = new Font("Segoe UI", 12F, FontStyle.Italic),
                    ForeColor = Color.White,
                    AutoSize = true
                };
                flowRecent.Controls.Add(lblEmpty);
            }
            else
            {
                int usableWidth = flowRecent.ClientSize.Width - flowRecent.Padding.Horizontal - 25;

                foreach (var product in RecentlyViewed.Items)
                {
                    var card = new ProductCard();
                    card.SetProduct(product);
                    card.SetCardWidth(usableWidth);

                    card.CardClicked += (s, clickedProduct) =>
                    {
                        ProductDetailPage detailPage = new ProductDetailPage(clickedProduct, this);
                        detailPage.Show();
                        this.Hide();
                    };

                    flowRecent.Controls.Add(card);
                }
            }

            flowRecent.ResumeLayout();
            isLoading = false;
        }


        private void RecentPage_VisibleChanged_1(object sender, EventArgs e)
        {
            if (this.Visible)
                LoadRecentProducts();
        }
    }
}