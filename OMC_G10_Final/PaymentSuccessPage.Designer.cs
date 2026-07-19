namespace OMC_G10_Final
{
    partial class PaymentSuccessPage
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
            pictureBox1 = new PictureBox();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            btnyes = new AntdUI.ButtonShadow();
            btnlater = new AntdUI.ButtonShadow();
            panel1 = new AntdUI.Panel();
            orderdetailspanel = new AntdUI.Panel();
            itemsorderdpanel = new AntdUI.Panel();
            deliverystatuspanel = new AntdUI.Panel();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            orderdetailspanel.SuspendLayout();
            itemsorderdpanel.SuspendLayout();
            deliverystatuspanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.green_check;
            pictureBox1.Location = new Point(496, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(245, 247, 231);
            label1.Location = new Point(280, 213);
            label1.Name = "label1";
            label1.Shadow = 4;
            label1.ShadowColor = SystemColors.ActiveCaptionText;
            label1.ShadowOffsetX = 4;
            label1.ShadowOffsetY = 4;
            label1.ShadowOpacity = 0.5F;
            label1.Size = new Size(682, 67);
            label1.TabIndex = 1;
            label1.Text = "Payment Successful";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(245, 247, 231);
            label2.Location = new Point(376, 286);
            label2.Name = "label2";
            label2.Shadow = 4;
            label2.ShadowColor = SystemColors.ActiveCaptionText;
            label2.ShadowOffsetX = 4;
            label2.ShadowOffsetY = 4;
            label2.ShadowOpacity = 0.5F;
            label2.Size = new Size(439, 45);
            label2.TabIndex = 2;
            label2.Text = "Thank You For Your Puchase";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(245, 247, 231);
            label3.Location = new Point(262, 337);
            label3.Name = "label3";
            label3.Shadow = 4;
            label3.ShadowColor = SystemColors.AppWorkspace;
            label3.ShadowOffsetX = 4;
            label3.ShadowOffsetY = 4;
            label3.ShadowOpacity = 0.5F;
            label3.Size = new Size(700, 45);
            label3.TabIndex = 3;
            label3.Text = "Would you like to complete your profile for future purchase ?";
            // 
            // btnyes
            // 
            btnyes.BackActive = Color.FromArgb(255, 220, 248);
            btnyes.BackColor = Color.FromArgb(255, 220, 248);
            btnyes.BackHover = Color.FromArgb(222, 158, 209);
            btnyes.BorderWidth = 3F;
            btnyes.DefaultBack = Color.FromArgb(255, 220, 248);
            btnyes.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnyes.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnyes.ForeColor = Color.FromArgb(107, 78, 57);
            btnyes.Location = new Point(406, 388);
            btnyes.Name = "btnyes";
            btnyes.ShadowColor = SystemColors.ActiveCaptionText;
            btnyes.ShadowOffsetX = 4;
            btnyes.ShadowOffsetY = 4;
            btnyes.ShadowOpacity = 0.6F;
            btnyes.Shape = AntdUI.TShape.Round;
            btnyes.Size = new Size(204, 56);
            btnyes.TabIndex = 42;
            btnyes.Text = "Yes";
            // 
            // btnlater
            // 
            btnlater.BackActive = Color.FromArgb(255, 220, 248);
            btnlater.BackColor = Color.FromArgb(255, 220, 248);
            btnlater.BackHover = Color.FromArgb(222, 158, 209);
            btnlater.BorderWidth = 3F;
            btnlater.DefaultBack = Color.FromArgb(255, 220, 248);
            btnlater.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnlater.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlater.ForeColor = Color.FromArgb(107, 78, 57);
            btnlater.Location = new Point(611, 388);
            btnlater.Name = "btnlater";
            btnlater.ShadowColor = SystemColors.ActiveCaptionText;
            btnlater.ShadowOffsetX = 4;
            btnlater.ShadowOffsetY = 4;
            btnlater.ShadowOpacity = 0.6F;
            btnlater.Shape = AntdUI.TShape.Round;
            btnlater.Size = new Size(204, 56);
            btnlater.TabIndex = 43;
            btnlater.Text = "Later";
            // 
            // panel1
            // 
            panel1.Controls.Add(deliverystatuspanel);
            panel1.Controls.Add(itemsorderdpanel);
            panel1.Controls.Add(orderdetailspanel);
            panel1.Location = new Point(12, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 263);
            panel1.TabIndex = 44;
            panel1.Text = "panel1";
            // 
            // orderdetailspanel
            // 
            orderdetailspanel.Back = Color.FromArgb(114, 84, 62);
            orderdetailspanel.BackColor = Color.Transparent;
            orderdetailspanel.Controls.Add(label4);
            orderdetailspanel.Location = new Point(3, 3);
            orderdetailspanel.Name = "orderdetailspanel";
            orderdetailspanel.Size = new Size(404, 257);
            orderdetailspanel.TabIndex = 0;
            orderdetailspanel.Text = "panel2";
            // 
            // itemsorderdpanel
            // 
            itemsorderdpanel.Back = Color.FromArgb(114, 84, 62);
            itemsorderdpanel.BackColor = Color.Transparent;
            itemsorderdpanel.Controls.Add(label5);
            itemsorderdpanel.Location = new Point(413, 3);
            itemsorderdpanel.Name = "itemsorderdpanel";
            itemsorderdpanel.Size = new Size(390, 257);
            itemsorderdpanel.TabIndex = 1;
            itemsorderdpanel.Text = "panel3";
            // 
            // deliverystatuspanel
            // 
            deliverystatuspanel.Back = Color.FromArgb(114, 84, 62);
            deliverystatuspanel.BackColor = Color.Transparent;
            deliverystatuspanel.Controls.Add(label6);
            deliverystatuspanel.Location = new Point(809, 3);
            deliverystatuspanel.Name = "deliverystatuspanel";
            deliverystatuspanel.Size = new Size(364, 257);
            deliverystatuspanel.TabIndex = 2;
            deliverystatuspanel.Text = "panel4";
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 220, 248);
            label4.Location = new Point(98, 15);
            label4.Name = "label4";
            label4.Size = new Size(183, 29);
            label4.TabIndex = 0;
            label4.Text = "Order Details";
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 220, 248);
            label5.Location = new Point(96, 15);
            label5.Name = "label5";
            label5.Size = new Size(196, 29);
            label5.TabIndex = 1;
            label5.Text = "Items Ordered";
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 220, 248);
            label6.Location = new Point(85, 15);
            label6.Name = "label6";
            label6.Size = new Size(214, 29);
            label6.TabIndex = 2;
            label6.Text = "Delivery Status";
            // 
            // PaymentSuccessPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(panel1);
            Controls.Add(btnlater);
            Controls.Add(btnyes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PaymentSuccessPage";
            Text = "PaymentSuccessPage";
            Load += PaymentSuccessPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            orderdetailspanel.ResumeLayout(false);
            itemsorderdpanel.ResumeLayout(false);
            deliverystatuspanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.ButtonShadow btnyes;
        private AntdUI.ButtonShadow btnlater;
        private AntdUI.Panel panel1;
        private AntdUI.Panel deliverystatuspanel;
        private AntdUI.Panel itemsorderdpanel;
        private AntdUI.Panel orderdetailspanel;
        private AntdUI.Label label4;
        private AntdUI.Label label6;
        private AntdUI.Label label5;
    }
}