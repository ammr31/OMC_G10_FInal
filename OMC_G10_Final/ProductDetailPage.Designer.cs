namespace OMC_G10_Final
{
    partial class ProductDetailPage
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
            label1 = new AntdUI.Label();
            panel1 = new AntdUI.Panel();
            btnaddtocart = new AntdUI.ButtonShadow();
            productpricedisplay = new AntdUI.Label();
            productnamedisplay = new AntdUI.Label();
            label2 = new AntdUI.Label();
            detailsdisplay = new AntdUI.Label();
            pictureBox1 = new PictureBox();
            panel2 = new AntdUI.Panel();
            label3 = new AntdUI.Label();
            btnback = new AntdUI.ButtonShadow();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            // label1
            // 
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(245, 247, 231);
            label1.Location = new Point(320, 81);
            label1.Name = "label1";
            label1.Shadow = 4;
            label1.ShadowColor = SystemColors.ActiveCaptionText;
            label1.ShadowOffsetX = 4;
            label1.ShadowOffsetY = 4;
            label1.ShadowOpacity = 0.4F;
            label1.Size = new Size(333, 48);
            label1.TabIndex = 5;
            label1.Text = "Product Name :";
            // 
            // panel1
            // 
            panel1.Back = Color.FromArgb(245, 247, 231);
            panel1.BackExtend = "";
            panel1.Controls.Add(btnaddtocart);
            panel1.Controls.Add(productpricedisplay);
            panel1.Controls.Add(productnamedisplay);
            panel1.Location = new Point(320, 135);
            panel1.Name = "panel1";
            panel1.Shadow = 4;
            panel1.ShadowColor = SystemColors.ActiveCaptionText;
            panel1.ShadowOffsetX = 4;
            panel1.ShadowOffsetY = 4;
            panel1.ShadowOpacity = 0.4F;
            panel1.Size = new Size(833, 206);
            panel1.TabIndex = 4;
            panel1.Text = "panel1";
            // 
            // btnaddtocart
            // 
            btnaddtocart.BackActive = Color.FromArgb(255, 220, 248);
            btnaddtocart.BackColor = Color.FromArgb(255, 220, 248);
            btnaddtocart.BackHover = Color.FromArgb(222, 158, 209);
            btnaddtocart.BorderWidth = 3F;
            btnaddtocart.DefaultBack = Color.FromArgb(255, 220, 248);
            btnaddtocart.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnaddtocart.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddtocart.ForeColor = Color.FromArgb(107, 78, 57);
            btnaddtocart.Location = new Point(8, 132);
            btnaddtocart.Name = "btnaddtocart";
            btnaddtocart.ShadowColor = SystemColors.ActiveCaptionText;
            btnaddtocart.ShadowOffsetX = 4;
            btnaddtocart.ShadowOffsetY = 4;
            btnaddtocart.ShadowOpacity = 0.6F;
            btnaddtocart.Shape = AntdUI.TShape.Round;
            btnaddtocart.Size = new Size(213, 66);
            btnaddtocart.TabIndex = 39;
            btnaddtocart.Text = "Add To Cart";
            btnaddtocart.Click += btnaddtocart_Click_1;
            // 
            // productpricedisplay
            // 
            productpricedisplay.BackColor = Color.Transparent;
            productpricedisplay.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productpricedisplay.ForeColor = Color.FromArgb(107, 78, 57);
            productpricedisplay.Location = new Point(19, 64);
            productpricedisplay.Name = "productpricedisplay";
            productpricedisplay.Size = new Size(236, 43);
            productpricedisplay.TabIndex = 1;
            productpricedisplay.Text = "(product price)";
            // 
            // productnamedisplay
            // 
            productnamedisplay.BackColor = Color.Transparent;
            productnamedisplay.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productnamedisplay.ForeColor = Color.FromArgb(107, 78, 57);
            productnamedisplay.Location = new Point(19, 11);
            productnamedisplay.Name = "productnamedisplay";
            productnamedisplay.Size = new Size(790, 47);
            productnamedisplay.TabIndex = 0;
            productnamedisplay.Text = "(product name)";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(245, 247, 231);
            label2.Location = new Point(24, 413);
            label2.Name = "label2";
            label2.Shadow = 4;
            label2.ShadowColor = SystemColors.ActiveCaptionText;
            label2.ShadowOffsetX = 4;
            label2.ShadowOffsetY = 4;
            label2.ShadowOpacity = 0.4F;
            label2.Size = new Size(143, 39);
            label2.TabIndex = 41;
            label2.Text = "Details :";
            // 
            // detailsdisplay
            // 
            detailsdisplay.BackColor = Color.Transparent;
            detailsdisplay.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailsdisplay.Location = new Point(173, 413);
            detailsdisplay.Name = "detailsdisplay";
            detailsdisplay.Size = new Size(308, 161);
            detailsdisplay.TabIndex = 40;
            detailsdisplay.Text = "(details)";
            detailsdisplay.TextAlign = ContentAlignment.TopLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.placeholder;
            pictureBox1.Location = new Point(24, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Back = Color.FromArgb(245, 247, 231);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(534, 368);
            panel2.Name = "panel2";
            panel2.Shadow = 4;
            panel2.ShadowColor = SystemColors.ActiveCaptionText;
            panel2.Size = new Size(635, 245);
            panel2.TabIndex = 42;
            panel2.Text = "panel2";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(107, 78, 57);
            label3.Location = new Point(8, 8);
            label3.Name = "label3";
            label3.Shadow = 4;
            label3.ShadowColor = SystemColors.ActiveCaptionText;
            label3.ShadowOffsetX = 4;
            label3.ShadowOffsetY = 4;
            label3.ShadowOpacity = 0.4F;
            label3.Size = new Size(327, 39);
            label3.TabIndex = 43;
            label3.Text = "Customer Review : ";
            // 
            // btnback
            // 
            btnback.BackActive = Color.Transparent;
            btnback.BackColor = Color.Transparent;
            btnback.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnback.Icon = Properties.Resources.back;
            btnback.IconRatio = 1F;
            btnback.IconSize = new Size(30, 30);
            btnback.Location = new Point(20, 9);
            btnback.Name = "btnback";
            btnback.ShadowColor = SystemColors.ActiveCaptionText;
            btnback.ShadowOffsetX = 4;
            btnback.ShadowOffsetY = 4;
            btnback.ShadowOpacity = 0.4F;
            btnback.Shape = AntdUI.TShape.Circle;
            btnback.Size = new Size(74, 63);
            btnback.TabIndex = 43;
            btnback.Click += btnback_Click_1;
            // 
            // ProductDetailPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnback);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(detailsdisplay);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(bottomNavigationBar1);
            Name = "ProductDetailPage";
            Text = "ProductDetailPage";
            Load += ProductDetailPage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BottomNavigationBar bottomNavigationBar1;
        private AntdUI.Label label1;
        private AntdUI.Panel panel1;
        private AntdUI.Label label2;
        private AntdUI.Label detailsdisplay;
        private AntdUI.ButtonShadow btnaddtocart;
        private AntdUI.Label productpricedisplay;
        private AntdUI.Label productnamedisplay;
        private PictureBox pictureBox1;
        private AntdUI.Panel panel2;
        private AntdUI.Label label3;
        private AntdUI.ButtonShadow btnback;
    }
}