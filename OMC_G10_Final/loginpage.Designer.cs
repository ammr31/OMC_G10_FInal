namespace OMC_G10_Final
{
    partial class loginpage
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnlogin = new AntdUI.Button();
            btnregister = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carecart1;
            pictureBox1.Location = new Point(413, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label1.Location = new Point(316, 414);
            label1.Name = "label1";
            label1.Size = new Size(114, 43);
            label1.TabIndex = 1;
            label1.Text = "E-Mail :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label2.Location = new Point(316, 463);
            label2.Name = "label2";
            label2.Size = new Size(185, 48);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(524, 414);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(296, 43);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(524, 471);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(296, 40);
            txtPassword.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.BackActive = Color.FromArgb(255, 220, 248);
            btnlogin.BackColor = Color.FromArgb(255, 220, 248);
            btnlogin.BackHover = Color.FromArgb(222, 158, 209);
            btnlogin.BorderWidth = 3F;
            btnlogin.DefaultBack = Color.FromArgb(255, 220, 248);
            btnlogin.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnlogin.DisplayStyle = AntdUI.TButtonDisplayStyle.Text;
            btnlogin.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.FromArgb(107, 78, 57);
            btnlogin.Location = new Point(340, 565);
            btnlogin.Name = "btnlogin";
            btnlogin.Shape = AntdUI.TShape.Round;
            btnlogin.Size = new Size(264, 79);
            btnlogin.TabIndex = 32;
            btnlogin.Text = "Log In";
            btnlogin.Click += btnlogin_Click;
            // 
            // btnregister
            // 
            btnregister.BackActive = Color.FromArgb(255, 220, 248);
            btnregister.BackColor = Color.FromArgb(255, 220, 248);
            btnregister.BackHover = Color.FromArgb(222, 158, 209);
            btnregister.BorderWidth = 3F;
            btnregister.DefaultBack = Color.FromArgb(255, 220, 248);
            btnregister.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnregister.DisplayStyle = AntdUI.TButtonDisplayStyle.Text;
            btnregister.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregister.ForeColor = Color.FromArgb(107, 78, 57);
            btnregister.Location = new Point(637, 565);
            btnregister.Name = "btnregister";
            btnregister.Shape = AntdUI.TShape.Round;
            btnregister.Size = new Size(264, 79);
            btnregister.TabIndex = 33;
            btnregister.Text = "Register";
            btnregister.Click += btnregister_Click;
            // 
            // loginpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnregister);
            Controls.Add(btnlogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "loginpage";
            Text = "loginpage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private AntdUI.Button btnlogin;
        private AntdUI.Button btnregister;
    }
}