namespace OMC_G10_Final
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            bottomNavigationBar1 = new BottomNavigationBar();
            txtName = new AntdUI.Input();
            txtPhoneNumber = new AntdUI.Input();
            txtEmail = new AntdUI.Input();
            radMale = new AntdUI.Radio();
            radfemale = new AntdUI.Radio();
            slctusercategory = new AntdUI.Select();
            pageHeader1 = new AntdUI.PageHeader();
            btnSupplierPage = new AntdUI.ButtonShadow();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            buttonShadow2 = new AntdUI.ButtonShadow();
            SuspendLayout();
            // 
            // bottomNavigationBar1
            // 
            bottomNavigationBar1.AutoSize = true;
            bottomNavigationBar1.Dock = DockStyle.Bottom;
            bottomNavigationBar1.Location = new Point(0, 619);
            bottomNavigationBar1.Name = "bottomNavigationBar1";
            bottomNavigationBar1.Size = new Size(1200, 106);
            bottomNavigationBar1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 10.8F);
            txtName.Location = new Point(206, 205);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.PrefixText = "";
            txtName.Size = new Size(501, 49);
            txtName.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Verdana", 10.8F);
            txtPhoneNumber.Location = new Point(357, 325);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.PrefixText = "";
            txtPhoneNumber.Size = new Size(362, 48);
            txtPhoneNumber.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 10.8F);
            txtEmail.Location = new Point(231, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.PrefixText = "";
            txtEmail.Size = new Size(488, 49);
            txtEmail.TabIndex = 19;
            // 
            // radMale
            // 
            radMale.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radMale.Location = new Point(263, 377);
            radMale.Name = "radMale";
            radMale.Size = new Size(107, 40);
            radMale.TabIndex = 20;
            radMale.Text = "Male";
            // 
            // radfemale
            // 
            radfemale.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radfemale.Location = new Point(376, 379);
            radfemale.Name = "radfemale";
            radfemale.Size = new Size(102, 38);
            radfemale.TabIndex = 21;
            radfemale.Text = "Female";
            // 
            // slctusercategory
            // 
            slctusercategory.Font = new Font("Verdana", 10.8F);
            slctusercategory.Items.AddRange(new object[] { "Deaf ", "Elderly" });
            slctusercategory.Location = new Point(830, 298);
            slctusercategory.Name = "slctusercategory";
            slctusercategory.PlaceholderText = "User Category";
            slctusercategory.Size = new Size(251, 46);
            slctusercategory.TabIndex = 22;
            // 
            // pageHeader1
            // 
            pageHeader1.Font = new Font("Verdana", 36F, FontStyle.Bold);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Icon = Properties.Resources.profilepink1;
            pageHeader1.IconRatio = 1F;
            pageHeader1.IconSvg = "";
            pageHeader1.Location = new Point(12, 12);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.ShowIcon = true;
            pageHeader1.Size = new Size(838, 105);
            pageHeader1.TabIndex = 23;
            pageHeader1.Text = "EDIT PROFILE";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // btnSupplierPage
            // 
            btnSupplierPage.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnSupplierPage.Icon = Properties.Resources.supplier;
            btnSupplierPage.IconRatio = 1F;
            btnSupplierPage.IconSize = new Size(60, 60);
            btnSupplierPage.Location = new Point(932, 12);
            btnSupplierPage.Name = "btnSupplierPage";
            btnSupplierPage.ShadowColor = SystemColors.ActiveCaptionText;
            btnSupplierPage.ShadowOffsetX = 4;
            btnSupplierPage.ShadowOffsetY = 4;
            btnSupplierPage.ShadowOpacity = 0.4F;
            btnSupplierPage.Shape = AntdUI.TShape.Round;
            btnSupplierPage.Size = new Size(117, 116);
            btnSupplierPage.TabIndex = 24;
            btnSupplierPage.Text = "buttonShadow1";
            btnSupplierPage.Click += btnSupplierPage_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(245, 247, 231);
            label1.Location = new Point(90, 214);
            label1.Name = "label1";
            label1.Shadow = 1;
            label1.ShadowColor = SystemColors.ActiveCaptionText;
            label1.ShadowOffsetX = 4;
            label1.ShadowOffsetY = 4;
            label1.ShadowOpacity = 0.4F;
            label1.Size = new Size(123, 31);
            label1.TabIndex = 25;
            label1.Text = "NAME :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(245, 247, 231);
            label2.Location = new Point(90, 278);
            label2.Name = "label2";
            label2.Shadow = 1;
            label2.ShadowColor = SystemColors.ActiveCaptionText;
            label2.ShadowOffsetX = 4;
            label2.ShadowOffsetY = 4;
            label2.ShadowOpacity = 0.4F;
            label2.Size = new Size(123, 31);
            label2.TabIndex = 26;
            label2.Text = "E-MAIL :";
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(245, 247, 231);
            label5.Location = new Point(90, 332);
            label5.Name = "label5";
            label5.Shadow = 1;
            label5.ShadowColor = SystemColors.ActiveCaptionText;
            label5.ShadowOffsetX = 4;
            label5.ShadowOffsetY = 4;
            label5.ShadowOpacity = 0.4F;
            label5.Size = new Size(256, 31);
            label5.TabIndex = 27;
            label5.Text = "PHONE NUMBER :";
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(245, 247, 231);
            label7.Location = new Point(90, 379);
            label7.Name = "label7";
            label7.Shadow = 1;
            label7.ShadowColor = SystemColors.ActiveCaptionText;
            label7.ShadowOffsetX = 4;
            label7.ShadowOffsetY = 4;
            label7.ShadowOpacity = 0.4F;
            label7.Size = new Size(145, 31);
            label7.TabIndex = 28;
            label7.Text = "GENDER :";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(245, 247, 231);
            label3.Location = new Point(830, 269);
            label3.Name = "label3";
            label3.Shadow = 1;
            label3.ShadowColor = SystemColors.ActiveCaptionText;
            label3.ShadowOffsetX = 4;
            label3.ShadowOffsetY = 4;
            label3.ShadowOpacity = 0.4F;
            label3.Size = new Size(256, 31);
            label3.TabIndex = 29;
            label3.Text = "USER CATEGORY :";
            // 
            // buttonShadow2
            // 
            buttonShadow2.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            buttonShadow2.Icon = (Image)resources.GetObject("buttonShadow2.Icon");
            buttonShadow2.IconRatio = 1F;
            buttonShadow2.IconSize = new Size(55, 55);
            buttonShadow2.Location = new Point(1055, 12);
            buttonShadow2.Name = "buttonShadow2";
            buttonShadow2.ShadowColor = SystemColors.ActiveCaptionText;
            buttonShadow2.ShadowOffsetX = 4;
            buttonShadow2.ShadowOffsetY = 4;
            buttonShadow2.ShadowOpacity = 0.4F;
            buttonShadow2.Shape = AntdUI.TShape.Round;
            buttonShadow2.Size = new Size(117, 116);
            buttonShadow2.TabIndex = 30;
            buttonShadow2.Text = "buttonShadow2";
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(buttonShadow2);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSupplierPage);
            Controls.Add(pageHeader1);
            Controls.Add(slctusercategory);
            Controls.Add(radfemale);
            Controls.Add(radMale);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(bottomNavigationBar1);
            Name = "ProfilePage";
            Text = "ProfilePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BottomNavigationBar bottomNavigationBar1;
        private AntdUI.Input txtName;
        private AntdUI.Input txtPhoneNumber;
        private AntdUI.Input txtEmail;
        private AntdUI.Radio radMale;
        private AntdUI.Radio radfemale;
        private AntdUI.Select slctusercategory;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.ButtonShadow btnSupplierPage;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label5;
        private AntdUI.Label label7;
        private AntdUI.Label label3;
        private AntdUI.ButtonShadow buttonShadow2;
    }
}