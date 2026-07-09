namespace OMC_G10_Final
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            bottomNavigationBar1 = new BottomNavigationBar();
            btnPageHearing = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            TogglesSwitchDeaf = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnPageMobility = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
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
            bottomNavigationBar1.TabIndex = 3;
            // 
            // btnPageHearing
            // 
            btnPageHearing.CustomizableEdges = customizableEdges7;
            btnPageHearing.DisabledState.BorderColor = Color.DarkGray;
            btnPageHearing.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPageHearing.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPageHearing.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPageHearing.FillColor = Color.FromArgb(107, 78, 57);
            btnPageHearing.FocusedColor = Color.FromArgb(107, 78, 57);
            btnPageHearing.Font = new Font("Segoe UI", 9F);
            btnPageHearing.ForeColor = Color.White;
            btnPageHearing.HoverState.BorderColor = Color.FromArgb(107, 78, 57);
            btnPageHearing.HoverState.CustomBorderColor = Color.FromArgb(107, 78, 57);
            btnPageHearing.HoverState.FillColor = Color.FromArgb(107, 78, 57);
            btnPageHearing.HoverState.ForeColor = Color.FromArgb(107, 78, 57);
            btnPageHearing.Image = Properties.Resources.deafness;
            btnPageHearing.ImageSize = new Size(150, 150);
            btnPageHearing.Location = new Point(645, 207);
            btnPageHearing.Name = "btnPageHearing";
            btnPageHearing.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnPageHearing.Size = new Size(192, 109);
            btnPageHearing.TabIndex = 5;
            btnPageHearing.Click += btnPageHearing_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 231);
            panel1.Controls.Add(TogglesSwitchDeaf);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 114);
            panel1.TabIndex = 6;
            // 
            // TogglesSwitchDeaf
            // 
            TogglesSwitchDeaf.Animated = true;
            TogglesSwitchDeaf.AutoRoundedCorners = true;
            TogglesSwitchDeaf.CheckedState.BorderColor = Color.FromArgb(138, 167, 66);
            TogglesSwitchDeaf.CheckedState.BorderRadius = 24;
            TogglesSwitchDeaf.CheckedState.FillColor = Color.FromArgb(138, 167, 66);
            TogglesSwitchDeaf.CheckedState.InnerBorderColor = Color.White;
            TogglesSwitchDeaf.CheckedState.InnerBorderRadius = 20;
            TogglesSwitchDeaf.CheckedState.InnerColor = Color.White;
            TogglesSwitchDeaf.CustomizableEdges = customizableEdges9;
            TogglesSwitchDeaf.Location = new Point(657, 29);
            TogglesSwitchDeaf.Name = "TogglesSwitchDeaf";
            TogglesSwitchDeaf.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TogglesSwitchDeaf.Size = new Size(130, 51);
            TogglesSwitchDeaf.TabIndex = 7;
            TogglesSwitchDeaf.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            TogglesSwitchDeaf.UncheckedState.BorderRadius = 24;
            TogglesSwitchDeaf.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            TogglesSwitchDeaf.UncheckedState.InnerBorderColor = Color.White;
            TogglesSwitchDeaf.UncheckedState.InnerBorderRadius = 20;
            TogglesSwitchDeaf.UncheckedState.InnerColor = Color.White;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hearing_inverted;
            pictureBox1.Location = new Point(170, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 78, 57);
            label2.Location = new Point(14, 80);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 7;
            label2.Text = "Deaf Friendly";
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(107, 78, 57);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(669, 71);
            label1.TabIndex = 7;
            label1.Text = "Accessibility Mode";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPageMobility
            // 
            btnMedicine.BackActive = Color.FromArgb(255, 220, 248);
            btnMedicine.BackColor = Color.FromArgb(255, 220, 248);
            btnMedicine.BackHover = Color.FromArgb(222, 158, 209);
            btnMedicine.BorderWidth = 3F;
            btnMedicine.DefaultBack = Color.FromArgb(255, 220, 248);
            btnMedicine.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnMedicine.DisplayStyle = AntdUI.TButtonDisplayStyle.Text;
            btnMedicine.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedicine.ForeColor = Color.FromArgb(107, 78, 57);
            btnMedicine.Location = new Point(333, 483);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Shape = AntdUI.TShape.Round;
            btnMedicine.Size = new Size(264, 79);
            btnMedicine.TabIndex = 10;
            btnMedicine.Text = "Medicine";
            btnMedicine.Click += btnMedicine_Click;
            // 
            // btnDailyNeeds
            // 
            btnDailyNeeds.BackActive = Color.FromArgb(255, 220, 248);
            btnDailyNeeds.BackColor = Color.FromArgb(255, 220, 248);
            btnDailyNeeds.BackHover = Color.FromArgb(222, 158, 209);
            btnDailyNeeds.BorderWidth = 3F;
            btnDailyNeeds.DefaultBack = Color.FromArgb(255, 220, 248);
            btnDailyNeeds.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnDailyNeeds.DisplayStyle = AntdUI.TButtonDisplayStyle.Text;
            btnDailyNeeds.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyNeeds.ForeColor = Color.FromArgb(107, 78, 57);
            btnDailyNeeds.Location = new Point(634, 481);
            btnDailyNeeds.Name = "btnDailyNeeds";
            btnDailyNeeds.Shape = AntdUI.TShape.Round;
            btnDailyNeeds.Size = new Size(264, 79);
            btnDailyNeeds.TabIndex = 11;
            btnDailyNeeds.Text = "Daily Needs";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wheelchair2;
            pictureBox1.Location = new Point(385, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(245, 247, 231);
            label3.Location = new Point(353, 319);
            label3.Name = "label3";
            label3.Size = new Size(186, 45);
            label3.TabIndex = 7;
            label3.Text = "Mobility";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(245, 247, 231);
            label4.Location = new Point(651, 319);
            label4.Name = "label4";
            label4.Size = new Size(184, 45);
            label4.TabIndex = 8;
            label4.Text = "Hearing";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnPageHearing);
            Controls.Add(btnPageMobility);
            Controls.Add(bottomNavigationBar1);
            Name = "MainPage";
            Text = "MainPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn1;
        private BottomNavigationBar bottomNavigationBar1;
        private CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Button btnPageHearing;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPageMobility;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TogglesSwitchDeaf;
        private Label label3;
        private Label label4;
    }
}
