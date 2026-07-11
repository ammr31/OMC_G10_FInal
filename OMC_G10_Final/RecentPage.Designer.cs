namespace OMC_G10_Final
{
    partial class RecentPage
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
            bottomNavigationBar2 = new BottomNavigationBar();
            SuspendLayout();
            // 
            // bottomNavigationBar2
            // 
            bottomNavigationBar2.AutoSize = true;
            bottomNavigationBar2.Dock = DockStyle.Bottom;
            bottomNavigationBar2.Location = new Point(0, 619);
            bottomNavigationBar2.Name = "bottomNavigationBar2";
            bottomNavigationBar2.Size = new Size(1200, 106);
            bottomNavigationBar2.TabIndex = 0;
            // 
            // RecentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(bottomNavigationBar2);
            Name = "RecentPage";
            Text = "RecentPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BottomNavigationBar bottomNavigationBar1;
        private BottomNavigationBar bottomNavigationBar2;
    }
}