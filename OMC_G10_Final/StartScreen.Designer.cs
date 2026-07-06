namespace OMC_G10_Final
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            btnLogo = new Button();
            SuspendLayout();
            // 
            // btnLogo
            // 
            btnLogo.AutoSize = true;
            btnLogo.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Image = (Image)resources.GetObject("btnLogo.Image");
            btnLogo.Location = new Point(326, 141);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(521, 455);
            btnLogo.TabIndex = 0;
            btnLogo.UseVisualStyleBackColor = true;
            btnLogo.Click += btnLogo_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1200, 725);
            Controls.Add(btnLogo);
            ForeColor = Color.FromArgb(108, 117, 82);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartScreen";
            Text = "StartScreen";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogo;
    }
}