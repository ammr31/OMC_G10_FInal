namespace OMC_G10_Final
{
    partial class QuestionRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            categorydisplay = new AntdUI.Label();
            answerdisplay = new AntdUI.Label();
            questiondisplay = new AntdUI.Label();
            panel1 = new AntdUI.Panel();
            btndelete = new AntdUI.Button();
            btnedit = new AntdUI.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // categorydisplay
            // 
            categorydisplay.BackColor = Color.White;
            categorydisplay.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categorydisplay.Location = new Point(321, 0);
            categorydisplay.Name = "categorydisplay";
            categorydisplay.Size = new Size(166, 83);
            categorydisplay.TabIndex = 14;
            categorydisplay.Text = "categorydisplay";
            categorydisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerdisplay
            // 
            answerdisplay.BackColor = Color.White;
            answerdisplay.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answerdisplay.Location = new Point(493, 0);
            answerdisplay.Name = "answerdisplay";
            answerdisplay.Size = new Size(512, 83);
            answerdisplay.TabIndex = 15;
            answerdisplay.Text = "answerdisplay";
            answerdisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // questiondisplay
            // 
            questiondisplay.BackColor = Color.White;
            questiondisplay.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questiondisplay.Location = new Point(12, 0);
            questiondisplay.Name = "questiondisplay";
            questiondisplay.Size = new Size(303, 83);
            questiondisplay.TabIndex = 17;
            questiondisplay.Text = "questiondisplay";
            questiondisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btndelete);
            panel1.Controls.Add(btnedit);
            panel1.Location = new Point(1011, 0);
            panel1.Name = "panel1";
            panel1.Radius = 0;
            panel1.Size = new Size(148, 83);
            panel1.TabIndex = 18;
            panel1.Text = "panel1";
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.FromArgb(198, 48, 44);
            btndelete.Location = new Point(0, 0);
            btndelete.Name = "btndelete";
            btndelete.Radius = 0;
            btndelete.Size = new Size(148, 38);
            btndelete.TabIndex = 1;
            btndelete.Text = "Delete";
            btndelete.Click += btndelete_Click;
            // 
            // btnedit
            // 
            btnedit.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnedit.ForeColor = Color.FromArgb(0, 74, 173);
            btnedit.Location = new Point(0, 44);
            btnedit.Name = "btnedit";
            btnedit.Radius = 0;
            btnedit.Size = new Size(148, 36);
            btnedit.TabIndex = 0;
            btnedit.Text = "Edit";
            btnedit.Click += btnedit_Click;
            // 
            // QuestionRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(questiondisplay);
            Controls.Add(answerdisplay);
            Controls.Add(categorydisplay);
            ForeColor = SystemColors.ControlText;
            Name = "QuestionRow";
            Size = new Size(1163, 86);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Label categorydisplay;
        private AntdUI.Label answerdisplay;
        private AntdUI.Label questiondisplay;
        private AntdUI.Panel panel1;
        private AntdUI.Button btndelete;
        private AntdUI.Button btnedit;
    }
}
