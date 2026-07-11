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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSupplierPage = new AntdUI.Button();
            btnAdminPage = new AntdUI.Button();
            txtName = new AntdUI.Input();
            txtPhoneNumber = new AntdUI.Input();
            txtEmail = new AntdUI.Input();
            radMale = new AntdUI.Radio();
            radfemale = new AntdUI.Radio();
            slctusercategory = new AntdUI.Select();
            pageHeader1 = new AntdUI.PageHeader();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(245, 247, 231);
            label2.Location = new Point(90, 219);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 3;
            label2.Text = "NAME : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(245, 247, 231);
            label3.Location = new Point(90, 379);
            label3.Name = "label3";
            label3.Size = new Size(158, 31);
            label3.TabIndex = 4;
            label3.Text = "GENDER : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(245, 247, 231);
            label4.Location = new Point(90, 333);
            label4.Name = "label4";
            label4.Size = new Size(261, 31);
            label4.TabIndex = 5;
            label4.Text = "PHONE NUMBER :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(245, 247, 231);
            label5.Location = new Point(90, 274);
            label5.Name = "label5";
            label5.Size = new Size(135, 31);
            label5.TabIndex = 6;
            label5.Text = "E-MAIL :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(245, 247, 231);
            label6.Location = new Point(830, 264);
            label6.Name = "label6";
            label6.Size = new Size(267, 31);
            label6.TabIndex = 12;
            label6.Text = "USER CATEGORY :";
            // 
            // btnSupplierPage
            // 
            btnSupplierPage.BackgroundImageLayout = AntdUI.TFit.Cover;
            btnSupplierPage.BackHover = SystemColors.ActiveBorder;
            btnSupplierPage.Icon = (Image)resources.GetObject("btnSupplierPage.Icon");
            btnSupplierPage.IconRatio = 3F;
            btnSupplierPage.Location = new Point(920, 12);
            btnSupplierPage.Name = "btnSupplierPage";
            btnSupplierPage.Shape = AntdUI.TShape.Circle;
            btnSupplierPage.Size = new Size(129, 116);
            btnSupplierPage.TabIndex = 14;
            btnSupplierPage.TextAlign = ContentAlignment.TopCenter;
            btnSupplierPage.Click += btnSupplierPage_Click;
            // 
            // btnAdminPage
            // 
            btnAdminPage.BackHover = SystemColors.ActiveBorder;
            btnAdminPage.Icon = (Image)resources.GetObject("btnAdminPage.Icon");
            btnAdminPage.IconRatio = 3F;
            btnAdminPage.Location = new Point(1055, 12);
            btnAdminPage.Name = "btnAdminPage";
            btnAdminPage.Shape = AntdUI.TShape.Circle;
            btnAdminPage.Size = new Size(133, 116);
            btnAdminPage.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 10.8F);
            txtName.Location = new Point(218, 214);
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
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(pageHeader1);
            Controls.Add(slctusercategory);
            Controls.Add(radfemale);
            Controls.Add(radMale);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(btnAdminPage);
            Controls.Add(btnSupplierPage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bottomNavigationBar1);
            Name = "ProfilePage";
            Text = "ProfilePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BottomNavigationBar bottomNavigationBar1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private AntdUI.Button btnSupplierPage;
        private AntdUI.Button btnAdminPage;
        private AntdUI.Input txtName;
        private AntdUI.Input txtPhoneNumber;
        private AntdUI.Input txtEmail;
        private AntdUI.Radio radMale;
        private AntdUI.Radio radfemale;
        private AntdUI.Select slctusercategory;
        private AntdUI.PageHeader pageHeader1;
    }
}