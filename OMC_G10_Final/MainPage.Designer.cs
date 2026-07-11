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
            bottomNavigationBar2 = new BottomNavigationBar();
            panel3 = new AntdUI.Panel();
            SwitchAccessibility = new AntdUI.Switch();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnCall = new AntdUI.Button();
            pictureBox3 = new PictureBox();
            label5 = new AntdUI.Label();
            pictureBox1 = new PictureBox();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            btnDailyNeeds = new AntdUI.Button();
            btnMedicine = new AntdUI.Button();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            btnMessage = new AntdUI.Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelchat = new Panel();
            lstQuestion = new ListBox();
            flowlayoutchat = new FlowLayoutPanel();
            btnsend = new AntdUI.Button();
            txtchatinput = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelchat.SuspendLayout();
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
            // panel3
            // 
            panel3.Back = Color.FromArgb(245, 247, 231);
            panel3.BackColor = Color.FromArgb(245, 247, 231);
            panel3.Controls.Add(SwitchAccessibility);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(23, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(793, 123);
            panel3.TabIndex = 10;
            panel3.Text = "panel3";
            // 
            // SwitchAccessibility
            // 
            SwitchAccessibility.Fill = Color.FromArgb(138, 167, 66);
            SwitchAccessibility.FillHover = Color.Green;
            SwitchAccessibility.Location = new Point(650, 33);
            SwitchAccessibility.Name = "SwitchAccessibility";
            SwitchAccessibility.Size = new Size(125, 58);
            SwitchAccessibility.TabIndex = 2;
            SwitchAccessibility.CheckedChanged += SwitchAccessibility_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(107, 78, 57);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(667, 78);
            label1.TabIndex = 0;
            label1.Text = "Accessibility Mode";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hearing_inverted;
            pictureBox2.Location = new Point(273, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 78, 57);
            label2.Location = new Point(47, 78);
            label2.Name = "label2";
            label2.Size = new Size(664, 45);
            label2.TabIndex = 1;
            label2.Text = "Deaf friendly ";
            // 
            // btnCall
            // 
            btnCall.BackActive = Color.FromArgb(245, 247, 231);
            btnCall.BackColor = Color.FromArgb(245, 247, 231);
            btnCall.DefaultBack = Color.FromArgb(245, 247, 231);
            btnCall.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnCall.Icon = Properties.Resources.telephone_call;
            btnCall.IconRatio = 1F;
            btnCall.IconSize = new Size(70, 70);
            btnCall.Location = new Point(3, 3);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(123, 117);
            btnCall.TabIndex = 11;
            btnCall.Text = "button1";
            btnCall.Click += btnCall_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.deafness;
            pictureBox3.Location = new Point(352, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(245, 247, 231);
            label5.Location = new Point(323, 142);
            label5.Name = "label5";
            label5.Size = new Size(183, 38);
            label5.TabIndex = 33;
            label5.Text = "HEARING";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wheelchair2;
            pictureBox1.Location = new Point(74, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(245, 247, 231);
            label4.Location = new Point(49, 142);
            label4.Name = "label4";
            label4.Size = new Size(183, 38);
            label4.TabIndex = 30;
            label4.Text = "MOBILITY ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(245, 247, 231);
            label3.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(107, 78, 57);
            label3.Location = new Point(161, 215);
            label3.Name = "label3";
            label3.Size = new Size(252, 92);
            label3.TabIndex = 27;
            label3.Text = "Category";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            btnDailyNeeds.Location = new Point(301, 311);
            btnDailyNeeds.Name = "btnDailyNeeds";
            btnDailyNeeds.Shape = AntdUI.TShape.Round;
            btnDailyNeeds.Size = new Size(264, 79);
            btnDailyNeeds.TabIndex = 32;
            btnDailyNeeds.Text = "Daily Needs";
            // 
            // btnMedicine
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
            btnMedicine.Location = new Point(0, 313);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Shape = AntdUI.TShape.Round;
            btnMedicine.Size = new Size(264, 79);
            btnMedicine.TabIndex = 31;
            btnMedicine.Text = "Medicine";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(100, 353);
            label6.Name = "label6";
            label6.Size = new Size(1069, 36);
            label6.TabIndex = 34;
            label6.Text = " Please contact our 24/7 CareCart Support at +60 12-3456789";
            label6.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.telephone_call;
            pictureBox4.Location = new Point(23, 334);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnMedicine);
            panel2.Controls.Add(btnDailyNeeds);
            panel2.Location = new Point(321, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 401);
            panel2.TabIndex = 36;
            // 
            // btnMessage
            // 
            btnMessage.BackActive = Color.FromArgb(245, 247, 231);
            btnMessage.BackColor = Color.FromArgb(245, 247, 231);
            btnMessage.DefaultBack = Color.FromArgb(245, 247, 231);
            btnMessage.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnMessage.Icon = Properties.Resources.bubble_chat;
            btnMessage.IconRatio = 1F;
            btnMessage.IconSize = new Size(80, 80);
            btnMessage.Location = new Point(132, 3);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(123, 117);
            btnMessage.TabIndex = 12;
            btnMessage.Text = "button2";
            btnMessage.Click += btnMessage_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(245, 247, 231);
            flowLayoutPanel1.Controls.Add(btnCall);
            flowLayoutPanel1.Controls.Add(btnMessage);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(903, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 123);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // panelchat
            // 
            panelchat.AutoScroll = true;
            panelchat.BackColor = Color.FromArgb(245, 247, 231);
            panelchat.BorderStyle = BorderStyle.FixedSingle;
            panelchat.Controls.Add(lstQuestion);
            panelchat.Controls.Add(flowlayoutchat);
            panelchat.Controls.Add(btnsend);
            panelchat.Controls.Add(txtchatinput);
            panelchat.Location = new Point(814, 177);
            panelchat.Name = "panelchat";
            panelchat.Size = new Size(374, 398);
            panelchat.TabIndex = 38;
            panelchat.Visible = false;
            // 
            // lstQuestion
            // 
            lstQuestion.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstQuestion.FormattingEnabled = true;
            lstQuestion.Location = new Point(20, 251);
            lstQuestion.Name = "lstQuestion";
            lstQuestion.Size = new Size(334, 64);
            lstQuestion.TabIndex = 34;
            lstQuestion.SelectedIndexChanged += lstQuestion_SelectedIndexChanged;
            // 
            // flowlayoutchat
            // 
            flowlayoutchat.AutoScroll = true;
            flowlayoutchat.BackColor = Color.White;
            flowlayoutchat.BorderStyle = BorderStyle.FixedSingle;
            flowlayoutchat.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowlayoutchat.Location = new Point(20, 17);
            flowlayoutchat.Margin = new Padding(3, 3, 10, 3);
            flowlayoutchat.Name = "flowlayoutchat";
            flowlayoutchat.Size = new Size(334, 214);
            flowlayoutchat.TabIndex = 3;
            // 
            // btnsend
            // 
            btnsend.DisplayStyle = AntdUI.TButtonDisplayStyle.Image;
            btnsend.Icon = Properties.Resources.send;
            btnsend.IconRatio = 1F;
            btnsend.IconSize = new Size(40, 40);
            btnsend.Location = new Point(287, 321);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(67, 68);
            btnsend.TabIndex = 2;
            btnsend.Text = "button1";
            btnsend.Click += btnsend_Click;
            // 
            // txtchatinput
            // 
            txtchatinput.BorderStyle = BorderStyle.FixedSingle;
            txtchatinput.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtchatinput.Location = new Point(20, 340);
            txtchatinput.Multiline = true;
            txtchatinput.Name = "txtchatinput";
            txtchatinput.Size = new Size(261, 40);
            txtchatinput.TabIndex = 1;
            txtchatinput.KeyDown += txtchatinput_KeyDown_1;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(panelchat);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(bottomNavigationBar2);
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelchat.ResumeLayout(false);
            panelchat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn1;
        private BottomNavigationBar bottomNavigationBar1;
        private CheckBox checkBox1;
        private BottomNavigationBar bottomNavigationBar2;
        private AntdUI.Panel panel3;
        private AntdUI.Switch SwitchAccessibility;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private AntdUI.Button btnCall;
        private PictureBox pictureBox3;
        private AntdUI.Label label5;
        private PictureBox pictureBox1;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Button btnDailyNeeds;
        private AntdUI.Button btnMedicine;
        private Label label6;
        private PictureBox pictureBox4;
        private Panel panel2;
        private AntdUI.Button btnMessage;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelchat;
        private AntdUI.Button btnsend;
        private TextBox txtchatinput;
        private FlowLayoutPanel flowlayoutchat;
        private ListBox lstQuestion;
    }
}
