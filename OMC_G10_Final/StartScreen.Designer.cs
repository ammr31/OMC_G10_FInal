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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLogIn = new Guna.UI2.WinForms.Guna2Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(469, 42);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(315, 314);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(108, 117, 82);
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 246, 236);
            label1.Location = new Point(290, 405);
            label1.Name = "label1";
            label1.Size = new Size(173, 46);
            label1.TabIndex = 1;
            label1.Text = "E-Mail :";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(108, 117, 82);
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(244, 246, 236);
            label2.Location = new Point(290, 490);
            label2.Name = "label2";
            label2.Size = new Size(173, 46);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // btnLogIn
            // 
            btnLogIn.AutoRoundedCorners = true;
            btnLogIn.BackColor = Color.FromArgb(108, 117, 82);
            btnLogIn.CustomizableEdges = customizableEdges2;
            btnLogIn.DisabledState.BorderColor = Color.DarkGray;
            btnLogIn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogIn.FillColor = Color.FromArgb(236, 241, 244);
            btnLogIn.Font = new Font("Segoe UI", 9F);
            btnLogIn.ForeColor = Color.FromArgb(102, 82, 62);
            btnLogIn.Location = new Point(517, 589);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnLogIn.Size = new Size(248, 56);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "LOG IN";
            btnLogIn.Click += btnLogIn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(244, 246, 236);
            textBox1.Location = new Point(469, 395);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 65);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(244, 246, 236);
            textBox2.Location = new Point(469, 481);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 65);
            textBox2.TabIndex = 7;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnLogIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2CirclePictureBox1);
            ForeColor = Color.FromArgb(244, 246, 236);
            Name = "StartScreen";
            Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnLogIn;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}