namespace OMC_G10_Final
{
    partial class StartScreen
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
            btnEnter = new AntdUI.Button();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnEnter.Icon = Properties.Resources.carecart;
            btnEnter.IconRatio = 1F;
            btnEnter.IconSize = new Size(400, 400);
            btnEnter.Location = new Point(356, 95);
            btnEnter.Name = "btnEnter";
            btnEnter.Shape = AntdUI.TShape.Circle;
            btnEnter.Size = new Size(575, 507);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "button1";
            btnEnter.Click += btnEnter_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 116, 83);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnEnter);
            Name = "StartScreen";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button btnEnter;
    }
}