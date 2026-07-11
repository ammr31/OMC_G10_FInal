namespace OMC_G10_Final
{
    partial class LoginPage
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
            label1 = new Label();
            txtPassword = new Label();
            txtEmail = new TextBox();
            txtEmailPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnlogin = new AntdUI.Button();
            btnregister = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(374, 392);
            label1.Name = "label1";
            label1.Size = new Size(135, 31);
            label1.TabIndex = 1;
            label1.Text = "E-MAIL :";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Verdana", 15F, FontStyle.Bold);
            txtPassword.ForeColor = SystemColors.Info;
            txtPassword.Location = new Point(314, 444);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(205, 31);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "PASSWORD : ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(560, 392);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 41);
            txtEmail.TabIndex = 3;
            // 
            // txtEmailPassword
            // 
            txtEmailPassword.Location = new Point(560, 444);
            txtEmailPassword.Multiline = true;
            txtEmailPassword.Name = "txtEmailPassword";
            txtEmailPassword.Size = new Size(320, 41);
            txtEmailPassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carecart;
            pictureBox1.Location = new Point(422, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            btnlogin.Location = new Point(314, 523);
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
            btnregister.Location = new Point(616, 523);
            btnregister.Name = "btnregister";
            btnregister.Shape = AntdUI.TShape.Round;
            btnregister.Size = new Size(264, 79);
            btnregister.TabIndex = 33;
            btnregister.Text = "Register";
            btnregister.Click += btnregister_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnregister);
            Controls.Add(btnlogin);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmailPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label txtPassword;
        private TextBox txtEmail;
        private TextBox txtEmailPassword;
        private PictureBox pictureBox1;
        private AntdUI.Button btnlogin;
        private AntdUI.Button btnregister;
    }
}