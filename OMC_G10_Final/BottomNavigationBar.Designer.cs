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
            btnProfilePage = new Button();
            btnCartPage = new Button();
            btnLikedPage = new Button();
            btnHomePage = new Button();
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
            btnProfilePage.Dock = DockStyle.Left;
            btnProfilePage.Location = new Point(915, 0);
            btnProfilePage.Name = "btnProfilePage";
            btnProfilePage.Size = new Size(305, 106);
            btnProfilePage.TabIndex = 5;
            btnProfilePage.Text = "Profile";
            btnProfilePage.UseVisualStyleBackColor = true;
            btnProfilePage.Click += btnProfilePage_Click;
            // 
            // btnCartPage
            // 
            btnCartPage.Dock = DockStyle.Left;
            btnCartPage.Location = new Point(610, 0);
            btnCartPage.Name = "btnCartPage";
            btnCartPage.Size = new Size(305, 106);
            btnCartPage.TabIndex = 2;
            btnCartPage.Text = "Cart";
            btnCartPage.UseVisualStyleBackColor = true;
            btnCartPage.Click += btnCartPage_Click;
            // 
            // btnLikedPage
            // 
            btnLikedPage.Dock = DockStyle.Left;
            btnLikedPage.Location = new Point(305, 0);
            btnLikedPage.Name = "btnLikedPage";
            btnLikedPage.Size = new Size(305, 106);
            btnLikedPage.TabIndex = 4;
            btnLikedPage.Text = "Liked";
            btnLikedPage.UseVisualStyleBackColor = true;
            btnLikedPage.Click += btnLikedPage_Click;
            // 
            // btnHomePage
            // 
            btnHomePage.Dock = DockStyle.Left;
            btnHomePage.Location = new Point(0, 0);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(305, 106);
            btnHomePage.TabIndex = 3;
            btnHomePage.Text = "Home";
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += btnHomePage_Click;
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
        private Button btnProfilePage;
        private Button btnCartPage;
        private Button btnLikedPage;
        private Button btnHomePage;
    }
}
