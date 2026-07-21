namespace OMC_G10_Final
{
    partial class Addnewquestionpage
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
            txtBusinessName = new AntdUI.Input();
            groupBox1 = new GroupBox();
            txtanswer = new AntdUI.Input();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbQuestionType = new AntdUI.Select();
            txtquestion = new AntdUI.Input();
            btnSubmit = new Button();
            label1 = new Label();
            pageHeader1 = new AntdUI.PageHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBusinessName
            // 
            txtBusinessName.BorderWidth = 2F;
            txtBusinessName.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusinessName.ForeColor = SystemColors.ControlText;
            txtBusinessName.Location = new Point(425, 147);
            txtBusinessName.Name = "txtBusinessName";
            txtBusinessName.PlaceholderColor = SystemColors.ActiveBorder;
            txtBusinessName.PlaceholderText = "Business Name";
            txtBusinessName.Size = new Size(556, 51);
            txtBusinessName.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(245, 247, 231);
            groupBox1.Controls.Add(txtanswer);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbQuestionType);
            groupBox1.Controls.Add(txtquestion);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(103, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(994, 631);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // txtanswer
            // 
            txtanswer.BorderWidth = 2F;
            txtanswer.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtanswer.ForeColor = SystemColors.ControlText;
            txtanswer.Location = new Point(324, 224);
            txtanswer.Multiline = true;
            txtanswer.Name = "txtanswer";
            txtanswer.PlaceholderColor = SystemColors.ActiveBorder;
            txtanswer.PlaceholderText = "Answer";
            txtanswer.Size = new Size(556, 119);
            txtanswer.TabIndex = 38;
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(101, 346);
            label7.Name = "label7";
            label7.Size = new Size(220, 41);
            label7.TabIndex = 36;
            label7.Text = "Question Type :";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(191, 233);
            label3.Name = "label3";
            label3.Size = new Size(133, 41);
            label3.TabIndex = 32;
            label3.Text = "Answer :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 123);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 31;
            label2.Text = "Question :";
            // 
            // cmbQuestionType
            // 
            cmbQuestionType.BorderWidth = 2F;
            cmbQuestionType.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbQuestionType.Items.AddRange(new object[] { "Hospital", "Clinic", "Medical Supplier" });
            cmbQuestionType.Location = new Point(322, 336);
            cmbQuestionType.Name = "cmbQuestionType";
            cmbQuestionType.PlaceholderText = "Question Type ";
            cmbQuestionType.Size = new Size(283, 51);
            cmbQuestionType.TabIndex = 30;
            // 
            // txtquestion
            // 
            txtquestion.BorderWidth = 2F;
            txtquestion.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtquestion.ForeColor = SystemColors.ControlText;
            txtquestion.Location = new Point(322, 111);
            txtquestion.Multiline = true;
            txtquestion.Name = "txtquestion";
            txtquestion.PlaceholderColor = SystemColors.ActiveBorder;
            txtquestion.PlaceholderText = "Question";
            txtquestion.Size = new Size(556, 119);
            txtquestion.TabIndex = 15;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 192, 192);
            btnSubmit.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(307, 435);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(345, 53);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(193, 23);
            label1.Name = "label1";
            label1.Size = new Size(605, 57);
            label1.TabIndex = 0;
            label1.Text = "ADD QUESTION FORM";
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
            pageHeader1.TabIndex = 44;
            pageHeader1.Text = "Back";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // Addnewquestionpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(pageHeader1);
            Controls.Add(groupBox1);
            Controls.Add(txtBusinessName);
            Name = "Addnewquestionpage";
            Text = "Addnewquestionpage";
            Load += Addnewquestionpage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Input txtBusinessName;
        private GroupBox groupBox1;
        private AntdUI.Input txtanswer;
        private Label label7;
        private Label label3;
        private Label label2;
        private AntdUI.Select cmbQuestionType;
        private AntdUI.Input txtquestion;
        private Button btnSubmit;
        private Label label1;
        private AntdUI.PageHeader pageHeader1;
    }
}