namespace OMC_G10_Final
{
    partial class ProductCard
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
            pictureBox1 = new PictureBox();
            panel1 = new AntdUI.Panel();
            label2 = new AntdUI.Label();
            detailsdisplay = new AntdUI.Label();
            btnaddtocart = new AntdUI.ButtonShadow();
            productpricedisplay = new AntdUI.Label();
            productnamedisplay = new AntdUI.Label();
            label1 = new AntdUI.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.placeholder;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Back = Color.FromArgb(245, 247, 231);
            panel1.BackExtend = "";
            panel1.Controls.Add(label2);
            panel1.Controls.Add(detailsdisplay);
            panel1.Controls.Add(btnaddtocart);
            panel1.Controls.Add(productpricedisplay);
            panel1.Controls.Add(productnamedisplay);
            panel1.Location = new Point(317, 55);
            panel1.Name = "panel1";
            panel1.Shadow = 4;
            panel1.ShadowColor = SystemColors.ActiveCaptionText;
            panel1.ShadowOffsetX = 4;
            panel1.ShadowOffsetY = 4;
            panel1.ShadowOpacity = 0.4F;
            panel1.Size = new Size(833, 206);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(107, 78, 57);
            label2.Location = new Point(342, 8);
            label2.Name = "label2";
            label2.Size = new Size(143, 39);
            label2.TabIndex = 41;
            label2.Text = "Details :";
            // 
            // detailsdisplay
            // 
            detailsdisplay.BackColor = Color.Transparent;
            detailsdisplay.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            detailsdisplay.Location = new Point(491, 19);
            detailsdisplay.Name = "detailsdisplay";
            detailsdisplay.Size = new Size(308, 161);
            detailsdisplay.TabIndex = 40;
            detailsdisplay.Text = "(details)";
            detailsdisplay.TextAlign = ContentAlignment.TopLeft;
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
            btnaddtocart.Click += btnaddtocart_Click;
            // 
            // productpricedisplay
            // 
            productpricedisplay.BackColor = Color.Transparent;
            productpricedisplay.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productpricedisplay.ForeColor = Color.FromArgb(107, 78, 57);
            productpricedisplay.Location = new Point(19, 85);
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
            productnamedisplay.Size = new Size(314, 81);
            productnamedisplay.TabIndex = 0;
            productnamedisplay.Text = "(product name)";
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(245, 247, 231);
            label1.Location = new Point(317, 12);
            label1.Name = "label1";
            label1.Shadow = 4;
            label1.ShadowColor = SystemColors.ActiveCaptionText;
            label1.ShadowOffsetX = 4;
            label1.ShadowOffsetY = 4;
            label1.ShadowOpacity = 0.4F;
            label1.Size = new Size(333, 48);
            label1.TabIndex = 2;
            label1.Text = "Product Name :";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "ProductCard";
            Size = new Size(1164, 282);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private AntdUI.Panel panel1;
        private AntdUI.Label productnamedisplay;
        private AntdUI.Label label1;
        private AntdUI.Label productpricedisplay;
        private AntdUI.Label label2;
        private AntdUI.Label detailsdisplay;
        private AntdUI.ButtonShadow btnaddtocart;
    }
}
