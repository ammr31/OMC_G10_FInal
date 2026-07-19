namespace OMC_G10_Final
{
    partial class ManageQuestionform
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
            pageHeader1 = new AntdUI.PageHeader();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.Size = new Size(1200, 98);
            pageHeader1.TabIndex = 1;
            pageHeader1.Text = "Manage FAQ Question";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(303, 83);
            label2.TabIndex = 12;
            label2.Text = "Question";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 171);
            label1.Name = "label1";
            label1.Size = new Size(166, 83);
            label1.TabIndex = 13;
            label1.Text = "Category";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(493, 171);
            label3.Name = "label3";
            label3.Size = new Size(512, 83);
            label3.TabIndex = 14;
            label3.Text = "Answer";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1011, 171);
            label4.Name = "label4";
            label4.Size = new Size(148, 83);
            label4.TabIndex = 15;
            label4.Text = "Action";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageQuestionform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pageHeader1);
            Name = "ManageQuestionform";
            Text = "ManageQuestionform";
            Load += ManageQuestionform_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
    }
}