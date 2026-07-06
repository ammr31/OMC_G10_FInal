namespace OMC_G10_Final
{
    partial class BottomNavigationBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnProfilePage = new Guna.UI2.WinForms.Guna2Button();
            btnCartPage = new Guna.UI2.WinForms.Guna2Button();
            btnLikedPage = new Guna.UI2.WinForms.Guna2Button();
            btnHomePage = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProfilePage);
            panel1.Controls.Add(btnCartPage);
            panel1.Controls.Add(btnLikedPage);
            panel1.Controls.Add(btnHomePage);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 106);
            panel1.TabIndex = 7;
            // 
            // btnProfilePage
            // 
            btnProfilePage.CustomBorderColor = Color.Black;
            btnProfilePage.CustomBorderThickness = new Padding(5, 0, 0, 5);
            btnProfilePage.CustomizableEdges = customizableEdges1;
            btnProfilePage.DisabledState.BorderColor = Color.DarkGray;
            btnProfilePage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProfilePage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProfilePage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProfilePage.Dock = DockStyle.Left;
            btnProfilePage.FillColor = Color.FromArgb(255, 220, 248);
            btnProfilePage.Font = new Font("Segoe UI", 9F);
            btnProfilePage.ForeColor = Color.Black;
            btnProfilePage.Image = Properties.Resources.profile;
            btnProfilePage.ImageSize = new Size(70, 70);
            btnProfilePage.Location = new Point(900, 0);
            btnProfilePage.Name = "btnProfilePage";
            btnProfilePage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnProfilePage.Size = new Size(300, 106);
            btnProfilePage.TabIndex = 11;
            btnProfilePage.Click += btnProfilePage_Click_1;
            // 
            // btnCartPage
            // 
            btnCartPage.CustomBorderColor = Color.Black;
            btnCartPage.CustomBorderThickness = new Padding(5, 0, 5, 5);
            btnCartPage.CustomizableEdges = customizableEdges3;
            btnCartPage.DisabledState.BorderColor = Color.DarkGray;
            btnCartPage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCartPage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCartPage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCartPage.Dock = DockStyle.Left;
            btnCartPage.FillColor = Color.FromArgb(255, 220, 248);
            btnCartPage.Font = new Font("Segoe UI", 9F);
            btnCartPage.ForeColor = Color.Black;
            btnCartPage.Image = Properties.Resources.shopping_cart;
            btnCartPage.ImageSize = new Size(70, 70);
            btnCartPage.Location = new Point(600, 0);
            btnCartPage.Name = "btnCartPage";
            btnCartPage.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCartPage.Size = new Size(300, 106);
            btnCartPage.TabIndex = 10;
            btnCartPage.Click += btnCartPage_Click_1;
            // 
            // btnLikedPage
            // 
            btnLikedPage.CustomBorderColor = Color.Black;
            btnLikedPage.CustomBorderThickness = new Padding(5, 0, 5, 5);
            btnLikedPage.CustomizableEdges = customizableEdges5;
            btnLikedPage.DisabledState.BorderColor = Color.DarkGray;
            btnLikedPage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLikedPage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLikedPage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLikedPage.Dock = DockStyle.Left;
            btnLikedPage.FillColor = Color.FromArgb(255, 220, 248);
            btnLikedPage.Font = new Font("Segoe UI", 9F);
            btnLikedPage.ForeColor = Color.Black;
            btnLikedPage.Image = Properties.Resources.heart;
            btnLikedPage.ImageSize = new Size(70, 70);
            btnLikedPage.Location = new Point(300, 0);
            btnLikedPage.Name = "btnLikedPage";
            btnLikedPage.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLikedPage.Size = new Size(300, 106);
            btnLikedPage.TabIndex = 9;
            btnLikedPage.Click += btnLikedPage_Click_1;
            // 
            // btnHomePage
            // 
            btnHomePage.CustomBorderColor = Color.Black;
            btnHomePage.CustomBorderThickness = new Padding(0, 0, 5, 5);
            btnHomePage.CustomizableEdges = customizableEdges7;
            btnHomePage.DisabledState.BorderColor = Color.DarkGray;
            btnHomePage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHomePage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHomePage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHomePage.Dock = DockStyle.Left;
            btnHomePage.FillColor = Color.FromArgb(255, 220, 248);
            btnHomePage.Font = new Font("Segoe UI", 9F);
            btnHomePage.ForeColor = Color.Black;
            btnHomePage.Image = Properties.Resources.home;
            btnHomePage.ImageSize = new Size(70, 70);
            btnHomePage.Location = new Point(0, 0);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnHomePage.Size = new Size(300, 106);
            btnHomePage.TabIndex = 8;
            btnHomePage.Click += btnHomePage_Click_1;
            // 
            // BottomNavigationBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Name = "BottomNavigationBar";
            Size = new Size(1200, 135);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnHomePage;
        private Guna.UI2.WinForms.Guna2Button btnProfilePage;
        private Guna.UI2.WinForms.Guna2Button btnCartPage;
        private Guna.UI2.WinForms.Guna2Button btnLikedPage;
    }
}
