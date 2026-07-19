namespace OMC_G10_Final
{
    partial class adminpage
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
            label6 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            buttonShadow1 = new AntdUI.ButtonShadow();
            buttonShadow2 = new AntdUI.ButtonShadow();
            pageHeader1.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.Controls.Add(label6);
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Icon = Properties.Resources.user;
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.ShowIcon = true;
            pageHeader1.Size = new Size(1200, 130);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = "Admin";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(245, 247, 231);
            label6.Location = new Point(741, 52);
            label6.Name = "label6";
            label6.Size = new Size(445, 64);
            label6.TabIndex = 17;
            label6.Text = "Partner Management";
            // 
            // label5
            // 
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(957, 253);
            label5.Name = "label5";
            label5.Size = new Size(229, 83);
            label5.TabIndex = 15;
            label5.Text = "Action";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(722, 253);
            label4.Name = "label4";
            label4.Size = new Size(229, 83);
            label4.TabIndex = 14;
            label4.Text = "Status";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(487, 253);
            label3.Name = "label3";
            label3.Size = new Size(229, 83);
            label3.TabIndex = 13;
            label3.Text = "Location";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 253);
            label2.Name = "label2";
            label2.Size = new Size(229, 83);
            label2.TabIndex = 12;
            label2.Text = "Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 253);
            label1.Name = "label1";
            label1.Size = new Size(229, 83);
            label1.TabIndex = 11;
            label1.Text = "Partner's Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonShadow1
            // 
            buttonShadow1.BorderWidth = 2F;
            buttonShadow1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShadow1.ForeColor = Color.FromArgb(107, 78, 57);
            buttonShadow1.Icon = Properties.Resources.Brown_add;
            buttonShadow1.IconRatio = 1F;
            buttonShadow1.IconSize = new Size(50, 25);
            buttonShadow1.Location = new Point(670, 182);
            buttonShadow1.Name = "buttonShadow1";
            buttonShadow1.ShadowOffsetX = 4;
            buttonShadow1.ShadowOffsetY = 4;
            buttonShadow1.ShadowOpacity = 0.5F;
            buttonShadow1.Size = new Size(210, 51);
            buttonShadow1.TabIndex = 16;
            buttonShadow1.Text = "New Partner";
            buttonShadow1.Click += buttonShadow1_Click;
            // 
            // buttonShadow2
            // 
            buttonShadow2.BorderWidth = 2F;
            buttonShadow2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShadow2.ForeColor = Color.FromArgb(107, 78, 57);
            buttonShadow2.IconRatio = 1F;
            buttonShadow2.IconSize = new Size(50, 25);
            buttonShadow2.Location = new Point(886, 182);
            buttonShadow2.Name = "buttonShadow2";
            buttonShadow2.ShadowOffsetX = 4;
            buttonShadow2.ShadowOffsetY = 4;
            buttonShadow2.ShadowOpacity = 0.5F;
            buttonShadow2.Size = new Size(281, 51);
            buttonShadow2.TabIndex = 17;
            buttonShadow2.Text = "Manage FAQ Question";
            buttonShadow2.Click += buttonShadow2_Click;
            // 
            // adminpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(buttonShadow2);
            Controls.Add(buttonShadow1);
            Controls.Add(label5);
            Controls.Add(pageHeader1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "adminpage";
            Text = "adminpage";
            Load += adminpage_Load_1;
            pageHeader1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.ButtonShadow buttonShadow1;
        private AntdUI.Label label6;
        private AntdUI.ButtonShadow buttonShadow2;
    }
}