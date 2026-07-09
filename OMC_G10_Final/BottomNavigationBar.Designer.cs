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
            panel1 = new Panel();
            btnProfilePage = new AntdUI.Button();
            btnCartPage = new AntdUI.Button();
            btnRecentPage = new AntdUI.Button();
            btnHomePage = new AntdUI.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProfilePage);
            panel1.Controls.Add(btnCartPage);
            panel1.Controls.Add(btnRecentPage);
            panel1.Controls.Add(btnHomePage);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 106);
            panel1.TabIndex = 7;
            // 
            // btnProfilePage
            // 
            btnProfilePage.BackHover = Color.FromArgb(250, 157, 231);
            btnProfilePage.BorderWidth = 3F;
            btnProfilePage.DefaultBack = Color.FromArgb(255, 220, 248);
            btnProfilePage.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnProfilePage.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnProfilePage.Dock = DockStyle.Left;
            btnProfilePage.Icon = Properties.Resources.profile;
            btnProfilePage.IconPosition = AntdUI.TAlignMini.None;
            btnProfilePage.IconRatio = 1F;
            btnProfilePage.IconSize = new Size(70, 70);
            btnProfilePage.Location = new Point(900, 0);
            btnProfilePage.Name = "btnProfilePage";
            btnProfilePage.Size = new Size(300, 106);
            btnProfilePage.TabIndex = 15;
            btnProfilePage.Text = "button4";
            btnProfilePage.Click += btnProfilePage_Click;
            // 
            // btnCartPage
            // 
            btnCartPage.BackHover = Color.FromArgb(250, 157, 231);
            btnCartPage.BorderWidth = 3F;
            btnCartPage.DefaultBack = Color.FromArgb(255, 220, 248);
            btnCartPage.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnCartPage.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnCartPage.Dock = DockStyle.Left;
            btnCartPage.Icon = Properties.Resources.shopping_cart;
            btnCartPage.IconPosition = AntdUI.TAlignMini.None;
            btnCartPage.IconRatio = 1F;
            btnCartPage.IconSize = new Size(70, 70);
            btnCartPage.Location = new Point(600, 0);
            btnCartPage.Name = "btnCartPage";
            btnCartPage.Size = new Size(300, 106);
            btnCartPage.TabIndex = 14;
            btnCartPage.Text = "button3";
            btnCartPage.Click += btnCartPage_Click_1;
            // 
            // btnRecentPage
            // 
            btnRecentPage.BackHover = Color.FromArgb(250, 157, 231);
            btnRecentPage.BorderWidth = 3F;
            btnRecentPage.DefaultBack = Color.FromArgb(255, 220, 248);
            btnRecentPage.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnRecentPage.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnRecentPage.Dock = DockStyle.Left;
            btnRecentPage.Icon = Properties.Resources.recent;
            btnRecentPage.IconPosition = AntdUI.TAlignMini.None;
            btnRecentPage.IconRatio = 1F;
            btnRecentPage.IconSize = new Size(70, 70);
            btnRecentPage.Location = new Point(300, 0);
            btnRecentPage.Name = "btnRecentPage";
            btnRecentPage.Size = new Size(300, 106);
            btnRecentPage.TabIndex = 13;
            btnRecentPage.Text = "button2";
            btnRecentPage.Click += btnRecentPage_Click;
            // 
            // btnHomePage
            // 
            btnHomePage.BackExtend = "0";
            btnHomePage.BackHover = Color.FromArgb(250, 157, 231);
            btnHomePage.BorderWidth = 3F;
            btnHomePage.DefaultBack = Color.FromArgb(255, 220, 248);
            btnHomePage.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnHomePage.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnHomePage.Dock = DockStyle.Left;
            btnHomePage.Icon = Properties.Resources.home;
            btnHomePage.IconPosition = AntdUI.TAlignMini.None;
            btnHomePage.IconRatio = 1F;
            btnHomePage.IconSize = new Size(70, 70);
            btnHomePage.Location = new Point(0, 0);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(300, 106);
            btnHomePage.TabIndex = 12;
            btnHomePage.Text = "button1";
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
        private AntdUI.Button btnHomePage;
        private AntdUI.Button btnProfilePage;
        private AntdUI.Button btnCartPage;
        private AntdUI.Button btnRecentPage;
    }
}
