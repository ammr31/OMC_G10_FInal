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
            pageHeader1 = new AntdUI.PageHeader();
            btnSupplierPage = new AntdUI.ButtonShadow();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            btnadminpage = new AntdUI.ButtonShadow();
            btnsave = new AntdUI.ButtonShadow();
            label4 = new AntdUI.Label();
            txtaddress = new AntdUI.Input();
            slctusercategory = new AntdUI.Select();
            btnlogout = new AntdUI.ButtonShadow();
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
            txtName.Location = new Point(434, 121);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.PrefixText = "";
            txtName.Size = new Size(501, 49);
            txtName.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Verdana", 10.8F);
            txtPhoneNumber.Location = new Point(434, 232);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.PrefixText = "";
            txtPhoneNumber.Size = new Size(501, 48);
            txtPhoneNumber.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 10.8F);
            txtEmail.Location = new Point(434, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.PrefixText = "";
            txtEmail.Size = new Size(501, 49);
            txtEmail.TabIndex = 19;
            // 
            // radMale
            // 
            radMale.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radMale.Location = new Point(434, 377);
            radMale.Name = "radMale";
            radMale.Size = new Size(107, 40);
            radMale.TabIndex = 20;
            radMale.Text = "Male";
            // 
            // radfemale
            // 
            radfemale.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radfemale.Location = new Point(547, 380);
            radfemale.Name = "radfemale";
            radfemale.Size = new Size(102, 38);
            radfemale.TabIndex = 21;
            radfemale.Text = "Female";
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
            label1.Location = new Point(324, 125);
            label1.Name = "label1";
            label1.Shadow = 1;
            label1.ShadowColor = SystemColors.ActiveCaptionText;
            label1.ShadowOffsetX = 4;
            label1.ShadowOffsetY = 4;
            label1.ShadowOpacity = 0.4F;
            label1.Size = new Size(104, 31);
            label1.TabIndex = 25;
            label1.Text = "NAME :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(245, 247, 231);
            label2.Location = new Point(305, 181);
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
            label5.Location = new Point(182, 239);
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
            label7.Location = new Point(293, 378);
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
            label3.Location = new Point(176, 431);
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
            // btnadminpage
            // 
            btnadminpage.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnadminpage.Icon = (Image)resources.GetObject("btnadminpage.Icon");
            btnadminpage.IconRatio = 1F;
            btnadminpage.IconSize = new Size(55, 55);
            btnadminpage.Location = new Point(1055, 12);
            btnadminpage.Name = "btnadminpage";
            btnadminpage.ShadowColor = SystemColors.ActiveCaptionText;
            btnadminpage.ShadowOffsetX = 4;
            btnadminpage.ShadowOffsetY = 4;
            btnadminpage.ShadowOpacity = 0.4F;
            btnadminpage.Shape = AntdUI.TShape.Round;
            btnadminpage.Size = new Size(117, 116);
            btnadminpage.TabIndex = 30;
            btnadminpage.Text = "buttonShadow2";
            btnadminpage.Click += btnadminpage_Click;
            // 
            // btnsave
            // 
            btnsave.BackActive = Color.FromArgb(255, 220, 248);
            btnsave.BackColor = Color.FromArgb(255, 220, 248);
            btnsave.BackHover = Color.FromArgb(222, 158, 209);
            btnsave.BorderWidth = 3F;
            btnsave.DefaultBack = Color.FromArgb(255, 220, 248);
            btnsave.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnsave.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            btnsave.ForeColor = Color.FromArgb(107, 78, 57);
            btnsave.Location = new Point(324, 481);
            btnsave.Name = "btnsave";
            btnsave.ShadowColor = SystemColors.ActiveCaptionText;
            btnsave.ShadowOffsetX = 4;
            btnsave.ShadowOffsetY = 4;
            btnsave.ShadowOpacity = 0.6F;
            btnsave.Shape = AntdUI.TShape.Round;
            btnsave.Size = new Size(264, 74);
            btnsave.TabIndex = 38;
            btnsave.Text = "Save";
            btnsave.Click += btnsave_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(245, 247, 231);
            label4.Location = new Point(278, 295);
            label4.Name = "label4";
            label4.Shadow = 1;
            label4.ShadowColor = SystemColors.ActiveCaptionText;
            label4.ShadowOffsetX = 4;
            label4.ShadowOffsetY = 4;
            label4.ShadowOpacity = 0.4F;
            label4.Size = new Size(160, 31);
            label4.TabIndex = 39;
            label4.Text = "ADDRESS : ";
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Verdana", 10.8F);
            txtaddress.Location = new Point(434, 286);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Address";
            txtaddress.PrefixText = "";
            txtaddress.Size = new Size(501, 85);
            txtaddress.TabIndex = 40;
            // 
            // slctusercategory
            // 
            slctusercategory.BorderWidth = 2F;
            slctusercategory.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            slctusercategory.Items.AddRange(new object[] { "Mobility (Elderly)", "Hearing (Deaf)" });
            slctusercategory.Location = new Point(434, 424);
            slctusercategory.Name = "slctusercategory";
            slctusercategory.PlaceholderText = "User Category";
            slctusercategory.Size = new Size(256, 51);
            slctusercategory.TabIndex = 41;
            // 
            // btnlogout
            // 
            btnlogout.BackActive = Color.FromArgb(255, 220, 248);
            btnlogout.BackColor = Color.FromArgb(255, 220, 248);
            btnlogout.BackHover = Color.FromArgb(222, 158, 209);
            btnlogout.BorderWidth = 3F;
            btnlogout.DefaultBack = Color.FromArgb(255, 220, 248);
            btnlogout.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnlogout.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            btnlogout.ForeColor = Color.FromArgb(107, 78, 57);
            btnlogout.Location = new Point(609, 481);
            btnlogout.Name = "btnlogout";
            btnlogout.ShadowColor = SystemColors.ActiveCaptionText;
            btnlogout.ShadowOffsetX = 4;
            btnlogout.ShadowOffsetY = 4;
            btnlogout.ShadowOpacity = 0.6F;
            btnlogout.Shape = AntdUI.TShape.Round;
            btnlogout.Size = new Size(264, 74);
            btnlogout.TabIndex = 42;
            btnlogout.Text = "Logout";
            btnlogout.Click += btnlogout_Click;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnlogout);
            Controls.Add(slctusercategory);
            Controls.Add(txtaddress);
            Controls.Add(label4);
            Controls.Add(btnsave);
            Controls.Add(btnadminpage);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSupplierPage);
            Controls.Add(pageHeader1);
            Controls.Add(radfemale);
            Controls.Add(radMale);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(bottomNavigationBar1);
            Name = "ProfilePage";
            Text = "ProfilePage";
            Load += ProfilePage_Load;
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
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.ButtonShadow btnSupplierPage;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label5;
        private AntdUI.Label label7;
        private AntdUI.Label label3;
        private AntdUI.ButtonShadow btnadminpage;
        private AntdUI.ButtonShadow btnsave;
        private AntdUI.Label label4;
        private AntdUI.Input txtaddress;
        private AntdUI.Select slctusercategory;
        private AntdUI.ButtonShadow btnlogout;
    }
}