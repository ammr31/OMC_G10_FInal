namespace OMC_G10_Final
{
    partial class LogInPage
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            btnLogIn = new AntdUI.Button();
            btnRegister = new AntdUI.Button();
            btnBack = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carecart1;
            pictureBox1.Location = new Point(391, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 394);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(545, 438);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(545, 493);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(445, 438);
            label1.Name = "label1";
            label1.Size = new Size(94, 29);
            label1.TabIndex = 3;
            label1.Text = "Email :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(400, 493);
            label2.Name = "label2";
            label2.Size = new Size(139, 29);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // btnLogIn
            // 
            btnLogIn.BackActive = Color.FromArgb(255, 220, 248);
            btnLogIn.BackColor = Color.FromArgb(255, 220, 248);
            btnLogIn.BackHover = Color.FromArgb(222, 158, 209);
            btnLogIn.BorderWidth = 3F;
            btnLogIn.DefaultBack = Color.FromArgb(255, 220, 248);
            btnLogIn.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnLogIn.DisplayStyle = AntdUI.TButtonDisplayStyle.Text;
            btnLogIn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.FromArgb(107, 78, 57);
            btnLogIn.Location = new Point(358, 551);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Shape = AntdUI.TShape.Round;
            btnLogIn.Size = new Size(264, 79);
            btnLogIn.TabIndex = 32;
            btnLogIn.Text = "Log In";
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackActive = Color.FromArgb(255, 220, 248);
            btnRegister.BackColor = Color.FromArgb(255, 220, 248);
            btnRegister.BackHover = Color.FromArgb(222, 158, 209);
            btnRegister.BorderWidth = 3F;
            btnRegister.DefaultBack = Color.FromArgb(255, 220, 248);
            btnRegister.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnRegister.DisplayStyle = AntdUI.TButtonDisplayStyle.Text;
            btnRegister.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(107, 78, 57);
            btnRegister.Location = new Point(628, 551);
            btnRegister.Name = "btnRegister";
            btnRegister.Shape = AntdUI.TShape.Round;
            btnRegister.Size = new Size(264, 79);
            btnRegister.TabIndex = 33;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.BorderWidth = 4F;
            btnBack.DefaultBack = Color.FromArgb(255, 220, 248);
            btnBack.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnBack.Icon = Properties.Resources.back;
            btnBack.IconRatio = 1F;
            btnBack.IconSize = new Size(60, 60);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Shape = AntdUI.TShape.Circle;
            btnBack.Size = new Size(110, 102);
            btnBack.TabIndex = 34;
            btnBack.Click += btnBack_Click;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(btnLogIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "LogInPage";
            Text = "LogInPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Button btnLogIn;
        private AntdUI.Button btnRegister;
        private AntdUI.Button btnBack;
    }
}