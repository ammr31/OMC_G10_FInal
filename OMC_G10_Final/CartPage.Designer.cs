namespace OMC_G10_Final
{
    partial class CartPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bottomNavigationBar1 = new BottomNavigationBar();
            pageHeader1 = new AntdUI.PageHeader();
            btncheckout = new AntdUI.ButtonShadow();
            SuspendLayout();
            // 
            // bottomNavigationBar1
            // 
            bottomNavigationBar1.AutoSize = true;
            bottomNavigationBar1.Dock = DockStyle.Bottom;
            bottomNavigationBar1.Location = new Point(0, 619);
            bottomNavigationBar1.Name = "bottomNavigationBar1";
            bottomNavigationBar1.Size = new Size(1200, 106);
            bottomNavigationBar1.TabIndex = 0;
            // 
            // pageHeader1
            // 
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.Size = new Size(1200, 103);
            pageHeader1.TabIndex = 1;
            pageHeader1.Text = "Shopping Cart";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.UseTitleFont = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // btncheckout
            // 
            btncheckout.BackActive = Color.FromArgb(255, 220, 248);
            btncheckout.BackColor = Color.FromArgb(255, 220, 248);
            btncheckout.BackHover = Color.FromArgb(222, 158, 209);
            btncheckout.BorderWidth = 3F;
            btncheckout.DefaultBack = Color.FromArgb(255, 220, 248);
            btncheckout.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btncheckout.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncheckout.ForeColor = Color.FromArgb(107, 78, 57);
            btncheckout.Location = new Point(473, 547);
            btncheckout.Name = "btncheckout";
            btncheckout.ShadowColor = SystemColors.ActiveCaptionText;
            btncheckout.ShadowOffsetX = 4;
            btncheckout.ShadowOffsetY = 4;
            btncheckout.ShadowOpacity = 0.6F;
            btncheckout.Shape = AntdUI.TShape.Round;
            btncheckout.Size = new Size(254, 66);
            btncheckout.TabIndex = 40;
            btncheckout.Text = "Checkout";
            btncheckout.Click += btncheckout_Click;
            // 
            // CartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btncheckout);
            Controls.Add(pageHeader1);
            Controls.Add(bottomNavigationBar1);
            Name = "CartPage";
            Text = "CartPage";
            Load += CartPage_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BottomNavigationBar bottomNavigationBar1;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.ButtonShadow btncheckout;
    }
}