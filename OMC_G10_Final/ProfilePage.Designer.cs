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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            label6 = new Label();
            cboUserCategory = new ComboBox();
            btnSupplierPage = new AntdUI.Button();
            btnAdminPage = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(42, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(245, 247, 231);
            label1.Location = new Point(196, 55);
            label1.Name = "label1";
            label1.Size = new Size(511, 73);
            label1.TabIndex = 2;
            label1.Text = "EDIT PROFILE";
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
            label3.Location = new Point(90, 317);
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
            label4.Location = new Point(90, 399);
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
            label5.Location = new Point(90, 486);
            label5.Name = "label5";
            label5.Size = new Size(135, 31);
            label5.TabIndex = 6;
            label5.Text = "E-MAIL :";
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 219);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(500, 31);
            txtName.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(357, 399);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(362, 31);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 486);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(488, 31);
            txtEmail.TabIndex = 9;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radMale.ForeColor = Color.FromArgb(245, 247, 231);
            radMale.Location = new Point(296, 320);
            radMale.Name = "radMale";
            radMale.Size = new Size(95, 29);
            radMale.TabIndex = 10;
            radMale.TabStop = true;
            radMale.Text = "MALE";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radFemale.ForeColor = Color.FromArgb(245, 247, 231);
            radFemale.Location = new Point(456, 320);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(122, 29);
            radFemale.TabIndex = 11;
            radFemale.TabStop = true;
            radFemale.Text = "FEMALE";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(245, 247, 231);
            label6.Location = new Point(821, 317);
            label6.Name = "label6";
            label6.Size = new Size(267, 31);
            label6.TabIndex = 12;
            label6.Text = "USER CATEGORY :";
            // 
            // cboUserCategory
            // 
            cboUserCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUserCategory.FormattingEnabled = true;
            cboUserCategory.Location = new Point(821, 362);
            cboUserCategory.Name = "cboUserCategory";
            cboUserCategory.Size = new Size(258, 28);
            cboUserCategory.TabIndex = 13;
            // 
            // btnSupplierPage
            // 
            btnSupplierPage.BackgroundImageLayout = AntdUI.TFit.Cover;
            btnSupplierPage.Icon = (Image)resources.GetObject("btnSupplierPage.Icon");
            btnSupplierPage.IconRatio = 3F;
            btnSupplierPage.Location = new Point(1003, 12);
            btnSupplierPage.Name = "btnSupplierPage";
            btnSupplierPage.Shape = AntdUI.TShape.Circle;
            btnSupplierPage.Size = new Size(94, 89);
            btnSupplierPage.TabIndex = 14;
            btnSupplierPage.TextAlign = ContentAlignment.TopCenter;
            btnSupplierPage.Click += btnSupplierPage_Click;
            // 
            // btnAdminPage
            // 
            btnAdminPage.Icon = (Image)resources.GetObject("btnAdminPage.Icon");
            btnAdminPage.IconRatio = 3F;
            btnAdminPage.Location = new Point(1094, 12);
            btnAdminPage.Name = "btnAdminPage";
            btnAdminPage.Shape = AntdUI.TShape.Circle;
            btnAdminPage.Size = new Size(94, 89);
            btnAdminPage.TabIndex = 15;
            btnAdminPage.Click += btnAdminPage_Click;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnAdminPage);
            Controls.Add(btnSupplierPage);
            Controls.Add(cboUserCategory);
            Controls.Add(label6);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(bottomNavigationBar1);
            Name = "ProfilePage";
            Text = "ProfilePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BottomNavigationBar bottomNavigationBar1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private RadioButton radMale;
        private RadioButton radFemale;
        private Label label6;
        private ComboBox cboUserCategory;
        private AntdUI.Button btnSupplierPage;
        private AntdUI.Button btnAdminPage;
    }
}