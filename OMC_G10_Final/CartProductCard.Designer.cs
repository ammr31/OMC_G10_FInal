namespace OMC_G10_Final
{
    partial class CartProductCard
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
            productnamedisplay = new AntdUI.Label();
            label1 = new AntdUI.Label();
            productpricedisplay = new AntdUI.Label();
            label2 = new AntdUI.Label();
            panel1 = new AntdUI.Panel();
            btnminus = new AntdUI.Button();
            btnplus = new AntdUI.Button();
            numberdisplay = new AntdUI.Label();
            btndelete = new AntdUI.Button();
            itemselect = new AntdUI.Checkbox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.placeholder;
            pictureBox1.Location = new Point(27, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // productnamedisplay
            // 
            productnamedisplay.BackColor = Color.Transparent;
            productnamedisplay.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productnamedisplay.ForeColor = Color.FromArgb(107, 78, 57);
            productnamedisplay.Location = new Point(232, 56);
            productnamedisplay.Name = "productnamedisplay";
            productnamedisplay.Size = new Size(314, 54);
            productnamedisplay.TabIndex = 2;
            productnamedisplay.Text = "(product name)";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(107, 78, 57);
            label1.Location = new Point(232, 3);
            label1.Name = "label1";
            label1.Size = new Size(252, 47);
            label1.TabIndex = 3;
            label1.Text = "Product Name:";
            // 
            // productpricedisplay
            // 
            productpricedisplay.BackColor = Color.Transparent;
            productpricedisplay.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productpricedisplay.ForeColor = Color.FromArgb(107, 78, 57);
            productpricedisplay.Location = new Point(232, 124);
            productpricedisplay.Name = "productpricedisplay";
            productpricedisplay.Size = new Size(236, 43);
            productpricedisplay.TabIndex = 4;
            productpricedisplay.Text = "(product price)";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 78, 57);
            label2.Location = new Point(39, 15);
            label2.Name = "label2";
            label2.Size = new Size(132, 43);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnminus);
            panel1.Controls.Add(btnplus);
            panel1.Controls.Add(numberdisplay);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(581, 21);
            panel1.Name = "panel1";
            panel1.Shadow = 4;
            panel1.ShadowOffsetX = 4;
            panel1.ShadowOffsetY = 4;
            panel1.ShadowOpacity = 0.5F;
            panel1.Size = new Size(213, 138);
            panel1.TabIndex = 6;
            panel1.Text = "panel1";
            // 
            // btnminus
            // 
            btnminus.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnminus.Icon = Properties.Resources.minus;
            btnminus.IconRatio = 1F;
            btnminus.Location = new Point(155, 68);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(55, 59);
            btnminus.TabIndex = 8;
            btnminus.Text = "button2";
            // 
            // btnplus
            // 
            btnplus.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnplus.Icon = Properties.Resources.plus;
            btnplus.IconRatio = 1F;
            btnplus.Location = new Point(6, 71);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(55, 59);
            btnplus.TabIndex = 7;
            btnplus.Text = "button1";
            // 
            // numberdisplay
            // 
            numberdisplay.BackColor = Color.White;
            numberdisplay.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberdisplay.Location = new Point(74, 74);
            numberdisplay.Name = "numberdisplay";
            numberdisplay.Size = new Size(75, 48);
            numberdisplay.TabIndex = 6;
            numberdisplay.Text = "numberdisplay";
            numberdisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btndelete
            // 
            btndelete.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btndelete.Icon = Properties.Resources.bin;
            btndelete.IconRatio = 1F;
            btndelete.IconSize = new Size(60, 60);
            btndelete.Location = new Point(800, 3);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(87, 90);
            btndelete.TabIndex = 9;
            btndelete.Text = "button1";
            // 
            // itemselect
            // 
            itemselect.BadgeSize = 10F;
            itemselect.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemselect.Location = new Point(800, 95);
            itemselect.Name = "itemselect";
            itemselect.Size = new Size(87, 91);
            itemselect.TabIndex = 10;
            itemselect.Text = "";
            // 
            // CartProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 231);
            Controls.Add(itemselect);
            Controls.Add(btndelete);
            Controls.Add(panel1);
            Controls.Add(productpricedisplay);
            Controls.Add(label1);
            Controls.Add(productnamedisplay);
            Controls.Add(pictureBox1);
            Name = "CartProductCard";
            Size = new Size(920, 202);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private AntdUI.Label productnamedisplay;
        private AntdUI.Label label1;
        private AntdUI.Label productpricedisplay;
        private AntdUI.Label label2;
        private AntdUI.Panel panel1;
        private AntdUI.Button btnminus;
        private AntdUI.Button btnplus;
        private AntdUI.Label numberdisplay;
        private AntdUI.Button btndelete;
        private AntdUI.Checkbox itemselect;
    }
}
