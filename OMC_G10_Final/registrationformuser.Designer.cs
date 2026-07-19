namespace OMC_G10_Final
{
    partial class registrationformuser
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
            groupBox1 = new GroupBox();
            slctIDType = new AntdUI.Select();
            slctUserCategory = new AntdUI.Select();
            slctGender = new AntdUI.Select();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new AntdUI.Input();
            txtconfirmpassword = new AntdUI.Input();
            txtid = new AntdUI.Input();
            txtpassword = new AntdUI.Input();
            txtContactNum = new AntdUI.Input();
            txtname = new AntdUI.Input();
            btnSubmitRegistration = new Button();
            label1 = new Label();
            pageHeader1 = new AntdUI.PageHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(245, 247, 231);
            groupBox1.Controls.Add(slctIDType);
            groupBox1.Controls.Add(slctUserCategory);
            groupBox1.Controls.Add(slctGender);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtconfirmpassword);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(txtContactNum);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(btnSubmitRegistration);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(144, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(913, 701);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // slctIDType
            // 
            slctIDType.BorderWidth = 2F;
            slctIDType.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            slctIDType.Items.AddRange(new object[] { "MyKad", "JKM_Card" });
            slctIDType.Location = new Point(484, 174);
            slctIDType.Name = "slctIDType";
            slctIDType.PlaceholderText = "ID Type";
            slctIDType.Size = new Size(187, 51);
            slctIDType.TabIndex = 32;
            // 
            // slctUserCategory
            // 
            slctUserCategory.BorderWidth = 2F;
            slctUserCategory.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            slctUserCategory.Items.AddRange(new object[] { "Mobility (Elderly)", "Hearing (Deaf)" });
            slctUserCategory.Location = new Point(677, 174);
            slctUserCategory.Name = "slctUserCategory";
            slctUserCategory.PlaceholderText = "User Category";
            slctUserCategory.Size = new Size(194, 51);
            slctUserCategory.TabIndex = 31;
            // 
            // slctGender
            // 
            slctGender.BorderWidth = 2F;
            slctGender.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            slctGender.Items.AddRange(new object[] { "Male", "Female" });
            slctGender.Location = new Point(285, 174);
            slctGender.Name = "slctGender";
            slctGender.PlaceholderText = "Gender";
            slctGender.Size = new Size(193, 51);
            slctGender.TabIndex = 30;
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 471);
            label7.Name = "label7";
            label7.Size = new Size(273, 25);
            label7.TabIndex = 29;
            label7.Text = "Confirm Password :";
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(128, 412);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 28;
            label6.Text = "Password :";
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 358);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 27;
            label5.Text = "ID Number :";
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(182, 302);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 26;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 243);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 25;
            label3.Text = "Phone Number :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 128);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 24;
            label2.Text = "Name :";
            // 
            // txtEmail
            // 
            txtEmail.BorderWidth = 2F;
            txtEmail.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.ControlText;
            txtEmail.Location = new Point(285, 288);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderColor = SystemColors.ActiveBorder;
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(586, 51);
            txtEmail.TabIndex = 21;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.BorderWidth = 2F;
            txtconfirmpassword.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtconfirmpassword.ForeColor = SystemColors.ControlText;
            txtconfirmpassword.Location = new Point(285, 459);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.PlaceholderText = "Confirm Password";
            txtconfirmpassword.Size = new Size(586, 51);
            txtconfirmpassword.TabIndex = 20;
            // 
            // txtid
            // 
            txtid.BorderWidth = 2F;
            txtid.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtid.ForeColor = SystemColors.ControlText;
            txtid.Location = new Point(285, 345);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "ID Number";
            txtid.Size = new Size(586, 51);
            txtid.TabIndex = 19;
            // 
            // txtpassword
            // 
            txtpassword.BorderWidth = 2F;
            txtpassword.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = SystemColors.ControlText;
            txtpassword.Location = new Point(285, 402);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(586, 51);
            txtpassword.TabIndex = 18;
            // 
            // txtContactNum
            // 
            txtContactNum.BorderWidth = 2F;
            txtContactNum.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContactNum.ForeColor = SystemColors.ControlText;
            txtContactNum.Location = new Point(285, 231);
            txtContactNum.Name = "txtContactNum";
            txtContactNum.PlaceholderColor = SystemColors.ActiveBorder;
            txtContactNum.PlaceholderText = "Phone Number";
            txtContactNum.Size = new Size(586, 51);
            txtContactNum.TabIndex = 17;
            // 
            // txtname
            // 
            txtname.BorderWidth = 2F;
            txtname.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtname.ForeColor = SystemColors.ControlText;
            txtname.Location = new Point(285, 117);
            txtname.Name = "txtname";
            txtname.PlaceholderColor = SystemColors.ActiveBorder;
            txtname.PlaceholderText = "Name";
            txtname.Size = new Size(586, 51);
            txtname.TabIndex = 15;
            // 
            // btnSubmitRegistration
            // 
            btnSubmitRegistration.BackColor = Color.FromArgb(255, 192, 192);
            btnSubmitRegistration.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRegistration.Location = new Point(296, 584);
            btnSubmitRegistration.Name = "btnSubmitRegistration";
            btnSubmitRegistration.Size = new Size(345, 53);
            btnSubmitRegistration.TabIndex = 13;
            btnSubmitRegistration.Text = "SUBMIT";
            btnSubmitRegistration.UseVisualStyleBackColor = false;
            btnSubmitRegistration.Click += btnSubmitRegistration_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(156, 57);
            label1.Name = "label1";
            label1.Size = new Size(603, 57);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION FORM";
            // 
            // pageHeader1
            // 
            pageHeader1.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Icon = Properties.Resources.profilepink1;
            pageHeader1.IconRatio = 1F;
            pageHeader1.IconSvg = "";
            pageHeader1.Location = new Point(12, 12);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.Size = new Size(92, 74);
            pageHeader1.TabIndex = 42;
            pageHeader1.Text = "Back";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // registrationformuser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(pageHeader1);
            Controls.Add(groupBox1);
            Name = "registrationformuser";
            Text = "registrationformuser";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSubmitRegistration;
        private Label label1;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Input txtname;
        private AntdUI.Input txtContactNum;
        private AntdUI.Input txtEmail;
        private AntdUI.Input txtconfirmpassword;
        private AntdUI.Input txtid;
        private AntdUI.Input txtpassword;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private AntdUI.Select slctIDType;
        private AntdUI.Select slctUserCategory;
        private AntdUI.Select slctGender;
    }
}