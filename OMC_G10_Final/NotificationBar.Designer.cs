namespace OMC_G10_Final
{
    partial class NotificationBar
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
            panel1 = new AntdUI.Panel();
            label1 = new AntdUI.Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Back = Color.FromArgb(245, 247, 231);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Shadow = 4;
            panel1.ShadowOffsetX = 4;
            panel1.ShadowOffsetY = 4;
            panel1.ShadowOpacity = 0.4F;
            panel1.Size = new Size(817, 150);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(230, 15);
            label1.Name = "label1";
            label1.Shadow = 4;
            label1.ShadowOffsetX = 4;
            label1.ShadowOffsetY = 4;
            label1.ShadowOpacity = 0.4F;
            label1.Size = new Size(503, 100);
            label1.TabIndex = 1;
            label1.Text = "A DELIVERY \r\nHAS ARRIVE FOR YOU !!\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carecart5;
            pictureBox1.Location = new Point(32, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NotificationBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "NotificationBar";
            Size = new Size(817, 150);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panel1;
        private PictureBox pictureBox1;
        private AntdUI.Label label1;
    }
}
