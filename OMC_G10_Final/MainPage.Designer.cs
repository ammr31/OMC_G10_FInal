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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            btnPageMobility = new Button();
            btnPageHearing = new Button();
            pictureBox1 = new PictureBox();
            chkOn = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(492, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // chkOn
            // 
            chkOn.Appearance = Appearance.Button;
            chkOn.BackColor = Color.LightGray;
            chkOn.FlatStyle = FlatStyle.Flat;
            chkOn.Location = new Point(416, 39);
            chkOn.Name = "chkOn";
            chkOn.Size = new Size(73, 35);
            chkOn.TabIndex = 3;
            chkOn.Text = "OFF";
            chkOn.TextAlign = ContentAlignment.MiddleCenter;
            chkOn.UseVisualStyleBackColor = false;
            chkOn.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(chkOn);
            Controls.Add(pictureBox1);
            Controls.Add(btnPageHearing);
            Controls.Add(btnPageMobility);
            Name = "MainPage";
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPageMobility;
        private Button btnPageHearing;
        private BottomNavigationBar bottomNavigationBar1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox chkOn;
    }
}
