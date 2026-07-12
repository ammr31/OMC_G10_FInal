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
            btnSubmitRegistration = new Button();
            txtBusinessEmail = new TextBox();
            txtBusinessContactNum = new TextBox();
            txtBusinessAddress = new TextBox();
            txtBusinessname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pageHeader1 = new AntdUI.PageHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(245, 247, 231);
            groupBox1.Controls.Add(btnSubmitRegistration);
            groupBox1.Controls.Add(txtBusinessEmail);
            groupBox1.Controls.Add(txtBusinessContactNum);
            groupBox1.Controls.Add(txtBusinessAddress);
            groupBox1.Controls.Add(txtBusinessname);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(144, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(913, 534);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnSubmitRegistration
            // 
            btnSubmitRegistration.BackColor = Color.FromArgb(255, 192, 192);
            btnSubmitRegistration.Font = new Font("Verdana", 13.8F, FontStyle.Italic);
            btnSubmitRegistration.Location = new Point(290, 421);
            btnSubmitRegistration.Name = "btnSubmitRegistration";
            btnSubmitRegistration.Size = new Size(345, 53);
            btnSubmitRegistration.TabIndex = 13;
            btnSubmitRegistration.Text = "SUBMIT";
            btnSubmitRegistration.UseVisualStyleBackColor = false;
            btnSubmitRegistration.Click += btnSubmitRegistration_Click;
            // 
            // txtBusinessEmail
            // 
            txtBusinessEmail.Location = new Point(397, 285);
            txtBusinessEmail.Name = "txtBusinessEmail";
            txtBusinessEmail.Size = new Size(440, 27);
            txtBusinessEmail.TabIndex = 11;
            // 
            // txtBusinessContactNum
            // 
            txtBusinessContactNum.Location = new Point(397, 242);
            txtBusinessContactNum.Name = "txtBusinessContactNum";
            txtBusinessContactNum.Size = new Size(440, 27);
            txtBusinessContactNum.TabIndex = 10;
            // 
            // txtBusinessAddress
            // 
            txtBusinessAddress.Location = new Point(397, 201);
            txtBusinessAddress.Name = "txtBusinessAddress";
            txtBusinessAddress.Size = new Size(440, 27);
            txtBusinessAddress.TabIndex = 9;
            // 
            // txtBusinessname
            // 
            txtBusinessname.Location = new Point(397, 158);
            txtBusinessname.Name = "txtBusinessname";
            txtBusinessname.Size = new Size(440, 27);
            txtBusinessname.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(108, 288);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 5;
            label6.Text = "E-mail Address : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 245);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 4;
            label5.Text = "Contact Number : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 204);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 3;
            label4.Text = "Delivery Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 161);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = " Name : ";
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
        private TextBox txtBusinessEmail;
        private TextBox txtBusinessContactNum;
        private TextBox txtBusinessAddress;
        private TextBox txtBusinessname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private AntdUI.PageHeader pageHeader1;
    }
}