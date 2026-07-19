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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            btnEnter = new AntdUI.Button();
            btnuserguidelines = new AntdUI.ButtonShadow();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnEnter.Icon = (Image)resources.GetObject("btnEnter.Icon");
            btnEnter.IconRatio = 1F;
            btnEnter.IconSize = new Size(450, 400);
            btnEnter.Location = new Point(347, 66);
            btnEnter.Name = "btnEnter";
            btnEnter.Shape = AntdUI.TShape.Circle;
            btnEnter.Size = new Size(569, 499);
            btnEnter.TabIndex = 0;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnuserguidelines
            // 
            btnuserguidelines.BackActive = Color.FromArgb(255, 220, 248);
            btnuserguidelines.BackColor = Color.FromArgb(255, 220, 248);
            btnuserguidelines.BackHover = Color.FromArgb(222, 158, 209);
            btnuserguidelines.BorderWidth = 3F;
            btnuserguidelines.DefaultBack = Color.FromArgb(255, 220, 248);
            btnuserguidelines.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnuserguidelines.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            btnuserguidelines.ForeColor = Color.FromArgb(107, 78, 57);
            btnuserguidelines.Location = new Point(849, 629);
            btnuserguidelines.Name = "btnuserguidelines";
            btnuserguidelines.ShadowColor = SystemColors.ActiveCaptionText;
            btnuserguidelines.ShadowOffsetX = 4;
            btnuserguidelines.ShadowOffsetY = 4;
            btnuserguidelines.ShadowOpacity = 0.6F;
            btnuserguidelines.Shape = AntdUI.TShape.Round;
            btnuserguidelines.Size = new Size(339, 84);
            btnuserguidelines.TabIndex = 39;
            btnuserguidelines.Text = "User guidelines";
            btnuserguidelines.Click += btnuserguidelines_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 116, 83);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnuserguidelines);
            Controls.Add(btnEnter);
            Name = "StartScreen";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button btnEnter;
        private AntdUI.ButtonShadow btnuserguidelines;
    }
}