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
            txtemail = new AntdUI.Input();
            txtpassword = new AntdUI.Input();
            btnlogin = new AntdUI.ButtonShadow();
            btnregister = new AntdUI.ButtonShadow();
            pageHeader1 = new AntdUI.PageHeader();
            checkbox1 = new AntdUI.Checkbox();
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
            label1.ForeColor = Color.FromArgb(245, 247, 231);
            label1.Location = new Point(358, 418);
            label1.Name = "label1";
            label1.Shadow = 1;
            label1.ShadowColor = SystemColors.ActiveCaptionText;
            label1.ShadowOffsetX = 4;
            label1.ShadowOffsetY = 4;
            label1.ShadowOpacity = 0.4F;
            label1.Size = new Size(114, 43);
            label1.TabIndex = 1;
            label1.Text = "E-Mail :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(245, 247, 231);
            label2.Location = new Point(307, 467);
            label2.Name = "label2";
            label2.Shadow = 1;
            label2.ShadowColor = SystemColors.ActiveCaptionText;
            label2.ShadowOffsetX = 4;
            label2.ShadowOffsetY = 4;
            label2.ShadowOpacity = 0.4F;
            label2.Size = new Size(185, 48);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Verdana", 10.8F);
            txtemail.Location = new Point(498, 410);
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "Email";
            txtemail.Size = new Size(356, 51);
            txtemail.TabIndex = 35;
            txtemail.Text = "farid1mut@gmail.com";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Verdana", 10.8F);
            txtpassword.Location = new Point(498, 467);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(356, 51);
            txtpassword.TabIndex = 36;
            txtpassword.Text = "123456789";
            // 
            // btnlogin
            // 
            btnlogin.BackActive = Color.FromArgb(255, 220, 248);
            btnlogin.BackColor = Color.FromArgb(255, 220, 248);
            btnlogin.BackHover = Color.FromArgb(222, 158, 209);
            btnlogin.BorderWidth = 3F;
            btnlogin.DefaultBack = Color.FromArgb(255, 220, 248);
            btnlogin.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnlogin.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            btnlogin.ForeColor = Color.FromArgb(107, 78, 57);
            btnlogin.Location = new Point(358, 570);
            btnlogin.Name = "btnlogin";
            btnlogin.ShadowColor = SystemColors.ActiveCaptionText;
            btnlogin.ShadowOffsetX = 4;
            btnlogin.ShadowOffsetY = 4;
            btnlogin.ShadowOpacity = 0.6F;
            btnlogin.Shape = AntdUI.TShape.Round;
            btnlogin.Size = new Size(264, 74);
            btnlogin.TabIndex = 37;
            btnlogin.Text = "Log In";
            btnlogin.Click += btnlogin_Click_1;
            // 
            // btnregister
            // 
            btnregister.BackActive = Color.FromArgb(255, 220, 248);
            btnregister.BackColor = Color.FromArgb(255, 220, 248);
            btnregister.BackHover = Color.FromArgb(222, 158, 209);
            btnregister.BorderWidth = 3F;
            btnregister.DefaultBack = Color.FromArgb(255, 220, 248);
            btnregister.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnregister.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            btnregister.ForeColor = Color.FromArgb(107, 78, 57);
            btnregister.Location = new Point(640, 570);
            btnregister.Name = "btnregister";
            btnregister.ShadowColor = SystemColors.ActiveCaptionText;
            btnregister.ShadowOffsetX = 4;
            btnregister.ShadowOffsetY = 4;
            btnregister.ShadowOpacity = 0.6F;
            btnregister.Shape = AntdUI.TShape.Round;
            btnregister.Size = new Size(264, 74);
            btnregister.TabIndex = 39;
            btnregister.Text = "Register";
            btnregister.Click += btnregister_Click;
            // 
            // pageHeader1
            // 
            pageHeader1.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Icon = Properties.Resources.profilepink1;
            pageHeader1.IconRatio = 1F;
            pageHeader1.IconSvg = "";
            pageHeader1.Location = new Point(12, 12);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.Size = new Size(171, 94);
            pageHeader1.TabIndex = 40;
            pageHeader1.Text = "Back";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick_1;
            // 
            // checkbox1
            // 
            checkbox1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkbox1.ForeColor = Color.FromArgb(245, 247, 231);
            checkbox1.Location = new Point(506, 524);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(199, 35);
            checkbox1.TabIndex = 41;
            checkbox1.Text = "Show Password";
            checkbox1.CheckedChanged += checkbox1_CheckedChanged;
            // 
            // loginpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(checkbox1);
            Controls.Add(pageHeader1);
            Controls.Add(btnregister);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "loginpage";
            Text = "loginpage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input txtemail;
        private AntdUI.Input txtpassword;
        private AntdUI.ButtonShadow btnlogin;
        private AntdUI.ButtonShadow btnregister;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Checkbox checkbox1;
    }
}