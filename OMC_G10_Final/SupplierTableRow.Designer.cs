namespace OMC_G10_Final
{
    partial class SupplierTableRow
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
            PartnersNameDisplay = new AntdUI.Label();
            Partnertypedisplay = new AntdUI.Label();
            partnerlocationdisplay = new AntdUI.Label();
            partnerstatusdisplay = new AntdUI.Label();
            panel1 = new AntdUI.Panel();
            btnedit = new AntdUI.Button();
            btndelete = new AntdUI.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PartnersNameDisplay
            // 
            PartnersNameDisplay.BackColor = Color.White;
            PartnersNameDisplay.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartnersNameDisplay.Location = new Point(3, 0);
            PartnersNameDisplay.Name = "PartnersNameDisplay";
            PartnersNameDisplay.Size = new Size(229, 83);
            PartnersNameDisplay.TabIndex = 0;
            PartnersNameDisplay.Text = "PartnersNameDisplay";
            PartnersNameDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Partnertypedisplay
            // 
            Partnertypedisplay.BackColor = Color.White;
            Partnertypedisplay.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Partnertypedisplay.Location = new Point(238, 0);
            Partnertypedisplay.Name = "Partnertypedisplay";
            Partnertypedisplay.Size = new Size(229, 83);
            Partnertypedisplay.TabIndex = 1;
            Partnertypedisplay.Text = "Partnertypedisplay";
            Partnertypedisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // partnerlocationdisplay
            // 
            partnerlocationdisplay.BackColor = Color.White;
            partnerlocationdisplay.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partnerlocationdisplay.Location = new Point(473, 0);
            partnerlocationdisplay.Name = "partnerlocationdisplay";
            partnerlocationdisplay.Size = new Size(229, 83);
            partnerlocationdisplay.TabIndex = 2;
            partnerlocationdisplay.Text = "partnerlocationdisplay";
            partnerlocationdisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // partnerstatusdisplay
            // 
            partnerstatusdisplay.BackColor = Color.White;
            partnerstatusdisplay.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partnerstatusdisplay.Location = new Point(708, 0);
            partnerstatusdisplay.Name = "partnerstatusdisplay";
            partnerstatusdisplay.Size = new Size(229, 83);
            partnerstatusdisplay.TabIndex = 3;
            partnerstatusdisplay.Text = "partnerstatusdisplay";
            partnerstatusdisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnedit);
            panel1.Controls.Add(btndelete);
            panel1.Location = new Point(943, 0);
            panel1.Name = "panel1";
            panel1.Radius = 0;
            panel1.Size = new Size(229, 83);
            panel1.TabIndex = 4;
            panel1.Text = "panel1";
            // 
            // btnedit
            // 
            btnedit.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            btnedit.ForeColor = Color.Blue;
            btnedit.Location = new Point(34, 42);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(152, 41);
            btnedit.TabIndex = 6;
            btnedit.Text = "Edit";
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.FromArgb(255, 44, 44);
            btndelete.Location = new Point(34, 0);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(152, 41);
            btndelete.TabIndex = 5;
            btndelete.Text = "Delete";
            btndelete.Click += btndelete_Click;
            // 
            // SupplierTableRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(partnerstatusdisplay);
            Controls.Add(partnerlocationdisplay);
            Controls.Add(Partnertypedisplay);
            Controls.Add(PartnersNameDisplay);
            Name = "SupplierTableRow";
            Size = new Size(1170, 87);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label PartnersNameDisplay;
        private AntdUI.Label Partnertypedisplay;
        private AntdUI.Label partnerlocationdisplay;
        private AntdUI.Label partnerstatusdisplay;
        private AntdUI.Panel panel1;
        private AntdUI.Button btnedit;
        private AntdUI.Button btndelete;
    }
}
