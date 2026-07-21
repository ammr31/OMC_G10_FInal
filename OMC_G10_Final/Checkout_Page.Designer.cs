namespace OMC_G10_Final
{
    partial class Checkout_Page
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
            panel1 = new AntdUI.Panel();
            Shippingtotaldisplay = new AntdUI.Label();
            Subtotaldisplay = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            panel2 = new AntdUI.Panel();
            Totaldisplay = new AntdUI.Label();
            label3 = new AntdUI.Label();
            panel3 = new AntdUI.Panel();
            rdcod = new AntdUI.Radio();
            label4 = new AntdUI.Label();
            rdewallet = new AntdUI.Radio();
            rdonlinebanking = new AntdUI.Radio();
            rdcard = new AntdUI.Radio();
            panel4 = new AntdUI.Panel();
            DPexpirydate = new DateTimePicker();
            checkbox1 = new AntdUI.Checkbox();
            label9 = new AntdUI.Label();
            txtCW = new AntdUI.Input();
            label8 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            txtnameoncard = new AntdUI.Input();
            txtcardnumber = new AntdUI.Input();
            label6 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            btnproceed = new AntdUI.ButtonShadow();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.Size = new Size(1200, 96);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = "Checkout Page";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.UseTitleFont = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // panel1
            // 
            panel1.Back = Color.FromArgb(245, 247, 231);
            panel1.Controls.Add(Shippingtotaldisplay);
            panel1.Controls.Add(Subtotaldisplay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 100);
            panel1.Name = "panel1";
            panel1.Radius = 10;
            panel1.Size = new Size(600, 166);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // Shippingtotaldisplay
            // 
            Shippingtotaldisplay.BackColor = Color.Transparent;
            Shippingtotaldisplay.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shippingtotaldisplay.Location = new Point(387, 104);
            Shippingtotaldisplay.Name = "Shippingtotaldisplay";
            Shippingtotaldisplay.Size = new Size(198, 40);
            Shippingtotaldisplay.TabIndex = 3;
            Shippingtotaldisplay.Text = "(shippingtotaldisplay)";
            // 
            // Subtotaldisplay
            // 
            Subtotaldisplay.BackColor = Color.Transparent;
            Subtotaldisplay.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subtotaldisplay.Location = new Point(387, 23);
            Subtotaldisplay.Name = "Subtotaldisplay";
            Subtotaldisplay.Size = new Size(198, 40);
            Subtotaldisplay.TabIndex = 2;
            Subtotaldisplay.Text = "(subtotaldisplay)";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(231, 29);
            label2.TabIndex = 1;
            label2.Text = "Shipping Total";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 0;
            label1.Text = "Subtotal";
            // 
            // panel2
            // 
            panel2.Back = Color.FromArgb(245, 247, 231);
            panel2.Controls.Add(Totaldisplay);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(33, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 76);
            panel2.TabIndex = 2;
            panel2.Text = "panel2";
            // 
            // Totaldisplay
            // 
            Totaldisplay.BackColor = Color.Transparent;
            Totaldisplay.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Totaldisplay.ForeColor = Color.FromArgb(138, 167, 66);
            Totaldisplay.Location = new Point(387, 11);
            Totaldisplay.Name = "Totaldisplay";
            Totaldisplay.Size = new Size(198, 40);
            Totaldisplay.TabIndex = 4;
            Totaldisplay.Text = "(totaldisplay)";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 22);
            label3.Name = "label3";
            label3.Size = new Size(154, 29);
            label3.TabIndex = 3;
            label3.Text = "Total";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdcod);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(rdewallet);
            panel3.Controls.Add(rdonlinebanking);
            panel3.Controls.Add(rdcard);
            panel3.Location = new Point(37, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(595, 216);
            panel3.TabIndex = 3;
            panel3.Text = "panel3";
            // 
            // rdcod
            // 
            rdcod.BackColor = Color.Transparent;
            rdcod.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rdcod.Location = new Point(297, 117);
            rdcod.Name = "rdcod";
            rdcod.Size = new Size(276, 42);
            rdcod.TabIndex = 5;
            rdcod.Text = "Cash On Delivery";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 22);
            label4.Name = "label4";
            label4.Size = new Size(301, 29);
            label4.TabIndex = 4;
            label4.Text = "Payment Method";
            // 
            // rdewallet
            // 
            rdewallet.BackColor = Color.Transparent;
            rdewallet.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rdewallet.Location = new Point(297, 69);
            rdewallet.Name = "rdewallet";
            rdewallet.Size = new Size(276, 42);
            rdewallet.TabIndex = 2;
            rdewallet.Text = "E-Wallet";
            // 
            // rdonlinebanking
            // 
            rdonlinebanking.BackColor = Color.Transparent;
            rdonlinebanking.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rdonlinebanking.Location = new Point(15, 117);
            rdonlinebanking.Name = "rdonlinebanking";
            rdonlinebanking.Size = new Size(276, 42);
            rdonlinebanking.TabIndex = 1;
            rdonlinebanking.Text = "FPX Online Banking";
            // 
            // rdcard
            // 
            rdcard.BackColor = Color.Transparent;
            rdcard.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rdcard.Location = new Point(15, 69);
            rdcard.Name = "rdcard";
            rdcard.Size = new Size(276, 42);
            rdcard.TabIndex = 0;
            rdcard.Text = "Credit / Debit Card";
            // 
            // panel4
            // 
            panel4.Back = Color.FromArgb(255, 220, 248);
            panel4.Controls.Add(DPexpirydate);
            panel4.Controls.Add(checkbox1);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtCW);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtnameoncard);
            panel4.Controls.Add(txtcardnumber);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(686, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(484, 484);
            panel4.TabIndex = 0;
            panel4.Text = "panel4";
            // 
            // DPexpirydate
            // 
            DPexpirydate.CustomFormat = "MM/yy";
            DPexpirydate.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DPexpirydate.Format = DateTimePickerFormat.Custom;
            DPexpirydate.Location = new Point(167, 128);
            DPexpirydate.Name = "DPexpirydate";
            DPexpirydate.Size = new Size(162, 28);
            DPexpirydate.TabIndex = 10;
            // 
            // checkbox1
            // 
            checkbox1.BackColor = Color.Transparent;
            checkbox1.ForeColor = SystemColors.ActiveCaption;
            checkbox1.Location = new Point(298, 245);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(31, 29);
            checkbox1.TabIndex = 9;
            checkbox1.Text = "";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 245);
            label9.Name = "label9";
            label9.Size = new Size(287, 29);
            label9.TabIndex = 8;
            label9.Text = "Save this card for future use";
            // 
            // txtCW
            // 
            txtCW.BorderWidth = 2F;
            txtCW.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCW.Location = new Point(159, 162);
            txtCW.Name = "txtCW";
            txtCW.PasswordChar = '*';
            txtCW.PlaceholderText = "Ex: 123";
            txtCW.Size = new Size(170, 49);
            txtCW.TabIndex = 7;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 172);
            label8.Name = "label8";
            label8.Size = new Size(50, 29);
            label8.TabIndex = 6;
            label8.Text = "CVV:";
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 127);
            label7.Name = "label7";
            label7.Size = new Size(117, 29);
            label7.TabIndex = 4;
            label7.Text = "Expiry date:";
            // 
            // txtnameoncard
            // 
            txtnameoncard.BorderWidth = 2F;
            txtnameoncard.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnameoncard.Location = new Point(159, 58);
            txtnameoncard.Name = "txtnameoncard";
            txtnameoncard.PlaceholderText = "Ex: CIMB Bank";
            txtnameoncard.Size = new Size(322, 49);
            txtnameoncard.TabIndex = 3;
            // 
            // txtcardnumber
            // 
            txtcardnumber.BorderWidth = 2F;
            txtcardnumber.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcardnumber.Location = new Point(159, 14);
            txtcardnumber.Name = "txtcardnumber";
            txtcardnumber.PlaceholderText = "Ex: 1234123412341234";
            txtcardnumber.Size = new Size(322, 49);
            txtcardnumber.TabIndex = 2;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 68);
            label6.Name = "label6";
            label6.Size = new Size(142, 29);
            label6.TabIndex = 1;
            label6.Text = "Bank Name:";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(136, 29);
            label5.TabIndex = 0;
            label5.Text = "Card Number:";
            // 
            // btnproceed
            // 
            btnproceed.BackActive = Color.FromArgb(255, 220, 248);
            btnproceed.BackColor = Color.FromArgb(255, 220, 248);
            btnproceed.BackHover = Color.FromArgb(222, 158, 209);
            btnproceed.BorderWidth = 3F;
            btnproceed.DefaultBack = Color.FromArgb(255, 220, 248);
            btnproceed.DefaultBorderColor = Color.FromArgb(107, 78, 57);
            btnproceed.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnproceed.ForeColor = Color.FromArgb(107, 78, 57);
            btnproceed.Location = new Point(471, 620);
            btnproceed.Name = "btnproceed";
            btnproceed.ShadowColor = SystemColors.ActiveCaptionText;
            btnproceed.ShadowOffsetX = 4;
            btnproceed.ShadowOffsetY = 4;
            btnproceed.ShadowOpacity = 0.6F;
            btnproceed.Shape = AntdUI.TShape.Round;
            btnproceed.Size = new Size(254, 66);
            btnproceed.TabIndex = 41;
            btnproceed.Text = "Proceed";
            btnproceed.Click += btnproceed_Click_1;
            // 
            // Checkout_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(btnproceed);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pageHeader1);
            Name = "Checkout_Page";
            Text = "Checkout_Page";
            Load += Checkout_Page_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Panel panel1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Panel panel2;
        private AntdUI.Label Shippingtotaldisplay;
        private AntdUI.Label Subtotaldisplay;
        private AntdUI.Label Totaldisplay;
        private AntdUI.Label label3;
        private AntdUI.Panel panel3;
        private AntdUI.Radio rdewallet;
        private AntdUI.Radio rdonlinebanking;
        private AntdUI.Radio rdcard;
        private AntdUI.Label label4;
        private AntdUI.Panel panel4;
        private AntdUI.Label label5;
        private AntdUI.Input txtCW;
        private AntdUI.Label label8;
        private AntdUI.Label label7;
        private AntdUI.Input txtnameoncard;
        private AntdUI.Input txtcardnumber;
        private AntdUI.Label label6;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Label label9;
        private AntdUI.ButtonShadow btnproceed;
        private DateTimePicker DPexpirydate;
        private AntdUI.Radio rdcod;
    }
}