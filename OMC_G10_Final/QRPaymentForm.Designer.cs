namespace OMC_G10_Final
{
    partial class QRPaymentForm
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
            btnnext = new AntdUI.ButtonShadow();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.placeholderQR;
            pictureBox1.Location = new Point(325, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(555, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnnext
            // 
            btnnext.BackActive = Color.FromArgb(255, 220, 248);
            btnnext.BackColor = Color.FromArgb(255, 220, 248);
            btnnext.BackHover = Color.FromArgb(222, 158, 209);
            btnnext.BorderWidth = 3F;
            btnnext.DefaultBack = Color.FromArgb(255, 220, 248);
            btnnext.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnnext.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnext.ForeColor = Color.FromArgb(107, 78, 57);
            btnnext.Location = new Point(473, 551);
            btnnext.Name = "btnnext";
            btnnext.ShadowColor = SystemColors.ActiveCaptionText;
            btnnext.ShadowOffsetX = 4;
            btnnext.ShadowOffsetY = 4;
            btnnext.ShadowOpacity = 0.6F;
            btnnext.Shape = AntdUI.TShape.Round;
            btnnext.Size = new Size(254, 66);
            btnnext.TabIndex = 42;
            btnnext.Text = "Next";
            // 
            // QRPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnnext);
            Controls.Add(pictureBox1);
            Name = "QRPaymentForm";
            Text = "QRPaymentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private AntdUI.ButtonShadow btnnext;
    }
}