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
            btnPageMobility = new Button();
            btnPageHearing = new Button();
            bottomNavigationBar1 = new BottomNavigationBar();
            SuspendLayout();
            // 
            // btnPageMobility
            // 
            btnPageMobility.Location = new Point(360, 260);
            btnPageMobility.Name = "btnPageMobility";
            btnPageMobility.Size = new Size(240, 111);
            btnPageMobility.TabIndex = 0;
            btnPageMobility.Text = "Mobility";
            btnPageMobility.UseVisualStyleBackColor = true;
            btnPageMobility.Click += btnPageMobility_Click;
            // 
            // btnPageHearing
            // 
            btnPageHearing.Location = new Point(600, 260);
            btnPageHearing.Name = "btnPageHearing";
            btnPageHearing.Size = new Size(240, 111);
            btnPageHearing.TabIndex = 1;
            btnPageHearing.Text = "Hearing";
            btnPageHearing.UseVisualStyleBackColor = true;
            btnPageHearing.Click += btnPageHearing_Click;
            // 
            // bottomNavigationBar1
            // 
            bottomNavigationBar1.AutoSize = true;
            bottomNavigationBar1.Dock = DockStyle.Bottom;
            bottomNavigationBar1.Location = new Point(0, 619);
            bottomNavigationBar1.Name = "bottomNavigationBar1";
            bottomNavigationBar1.Size = new Size(1200, 106);
            bottomNavigationBar1.TabIndex = 2;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(bottomNavigationBar1);
            Controls.Add(btnPageHearing);
            Controls.Add(btnPageMobility);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPageMobility;
        private Button btnPageHearing;
        private BottomNavigationBar bottomNavigationBar1;
    }
}
