namespace OMC_G10_Final
{
    partial class SupplierPage
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
            groupBox1 = new GroupBox();
            txtproductimage = new AntdUI.Input();
            txtproductname = new AntdUI.Input();
            txtproductprice = new AntdUI.Input();
            txtproductdetails = new AntdUI.Input();
            label10 = new Label();
            slctCategory = new AntdUI.Select();
            label9 = new Label();
            txtQuantityAdd = new AntdUI.Input();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnsave = new Button();
            txtquantityrestock = new AntdUI.Input();
            slctproduct = new AntdUI.Select();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            pageHeader1 = new AntdUI.PageHeader();
            cmbChooseProduct = new AntdUI.Select();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(245, 247, 231);
            groupBox1.Controls.Add(txtproductimage);
            groupBox1.Controls.Add(txtproductname);
            groupBox1.Controls.Add(txtproductprice);
            groupBox1.Controls.Add(txtproductdetails);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(slctCategory);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtQuantityAdd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(77, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 555);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtproductimage
            // 
            txtproductimage.BorderWidth = 2F;
            txtproductimage.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtproductimage.ForeColor = SystemColors.ControlText;
            txtproductimage.Location = new Point(193, 151);
            txtproductimage.Name = "txtproductimage";
            txtproductimage.PlaceholderColor = SystemColors.ActiveBorder;
            txtproductimage.PlaceholderText = "Product Image";
            txtproductimage.Size = new Size(407, 47);
            txtproductimage.TabIndex = 53;
            // 
            // txtproductname
            // 
            txtproductname.BorderWidth = 2F;
            txtproductname.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtproductname.ForeColor = SystemColors.ControlText;
            txtproductname.Location = new Point(193, 111);
            txtproductname.Name = "txtproductname";
            txtproductname.PlaceholderColor = SystemColors.ActiveBorder;
            txtproductname.PlaceholderText = "Product Name";
            txtproductname.Size = new Size(407, 47);
            txtproductname.TabIndex = 52;
            // 
            // txtproductprice
            // 
            txtproductprice.BorderWidth = 2F;
            txtproductprice.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtproductprice.ForeColor = SystemColors.ControlText;
            txtproductprice.Location = new Point(193, 193);
            txtproductprice.Name = "txtproductprice";
            txtproductprice.PlaceholderColor = SystemColors.ActiveBorder;
            txtproductprice.PlaceholderText = "Product Price";
            txtproductprice.Size = new Size(407, 47);
            txtproductprice.TabIndex = 51;
            // 
            // txtproductdetails
            // 
            txtproductdetails.BorderWidth = 2F;
            txtproductdetails.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtproductdetails.ForeColor = SystemColors.ControlText;
            txtproductdetails.Location = new Point(193, 234);
            txtproductdetails.Multiline = true;
            txtproductdetails.Name = "txtproductdetails";
            txtproductdetails.PlaceholderColor = SystemColors.ActiveBorder;
            txtproductdetails.PlaceholderText = "Product Details";
            txtproductdetails.Size = new Size(407, 99);
            txtproductdetails.TabIndex = 50;
            // 
            // label10
            // 
            label10.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 377);
            label10.Name = "label10";
            label10.Size = new Size(189, 29);
            label10.TabIndex = 49;
            label10.Text = "Product Category:";
            // 
            // slctCategory
            // 
            slctCategory.BorderWidth = 2F;
            slctCategory.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            slctCategory.Items.AddRange(new object[] { "Medecine", "Daily Needs" });
            slctCategory.Location = new Point(193, 368);
            slctCategory.Name = "slctCategory";
            slctCategory.PlaceholderText = "Choose Category";
            slctCategory.Size = new Size(298, 47);
            slctCategory.TabIndex = 48;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 336);
            label9.Name = "label9";
            label9.Size = new Size(179, 29);
            label9.TabIndex = 26;
            label9.Text = "Product Quantity:";
            // 
            // txtQuantityAdd
            // 
            txtQuantityAdd.BorderWidth = 2F;
            txtQuantityAdd.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantityAdd.ForeColor = SystemColors.ControlText;
            txtQuantityAdd.Location = new Point(193, 327);
            txtQuantityAdd.Name = "txtQuantityAdd";
            txtQuantityAdd.PlaceholderColor = SystemColors.ActiveBorder;
            txtQuantityAdd.PlaceholderText = "Product Quantity";
            txtQuantityAdd.Size = new Size(407, 47);
            txtQuantityAdd.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 247);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 24;
            label6.Text = "Product Details:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 203);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 22;
            label5.Text = "Product Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 160);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 20;
            label4.Text = "Product Image:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 192, 192);
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Verdana", 15F, FontStyle.Bold);
            btnSubmit.Location = new Point(123, 435);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(328, 83);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 124);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 1;
            label3.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(101, 33);
            label1.Name = "label1";
            label1.Size = new Size(399, 41);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW PRODUCT";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(245, 247, 231);
            groupBox2.Controls.Add(btnsave);
            groupBox2.Controls.Add(txtquantityrestock);
            groupBox2.Controls.Add(slctproduct);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(689, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(468, 555);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(255, 192, 192);
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.Font = new Font("Verdana", 15F, FontStyle.Bold);
            btnsave.Location = new Point(87, 435);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(328, 83);
            btnsave.TabIndex = 54;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // txtquantityrestock
            // 
            txtquantityrestock.BorderWidth = 2F;
            txtquantityrestock.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtquantityrestock.ForeColor = SystemColors.ControlText;
            txtquantityrestock.Location = new Point(170, 193);
            txtquantityrestock.Name = "txtquantityrestock";
            txtquantityrestock.PlaceholderColor = SystemColors.ActiveBorder;
            txtquantityrestock.PlaceholderText = "Product Quantity Restock";
            txtquantityrestock.Size = new Size(298, 47);
            txtquantityrestock.TabIndex = 54;
            // 
            // slctproduct
            // 
            slctproduct.BorderWidth = 2F;
            slctproduct.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            slctproduct.Items.AddRange(new object[] { "Medecine", "Daily Needs" });
            slctproduct.Location = new Point(170, 151);
            slctproduct.Name = "slctproduct";
            slctproduct.PlaceholderText = "Choose Product";
            slctproduct.Size = new Size(298, 47);
            slctproduct.TabIndex = 54;
            // 
            // label8
            // 
            label8.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(-2, 206);
            label8.Name = "label8";
            label8.Size = new Size(178, 50);
            label8.TabIndex = 47;
            label8.Text = "Product Quantity Restock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 166);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 45;
            label7.Text = "Choose Prodcut:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 64, 64);
            label2.Location = new Point(35, 51);
            label2.Name = "label2";
            label2.Size = new Size(392, 41);
            label2.TabIndex = 1;
            label2.Text = "RESTOCK PRODUCT";
            // 
            // pageHeader1
            // 
            pageHeader1.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.ForeColor = Color.FromArgb(245, 247, 231);
            pageHeader1.Icon = Properties.Resources.profilepink1;
            pageHeader1.IconRatio = 1F;
            pageHeader1.IconSvg = "";
            pageHeader1.Location = new Point(0, 12);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowBack = true;
            pageHeader1.Size = new Size(73, 74);
            pageHeader1.TabIndex = 44;
            pageHeader1.Text = "Back";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            pageHeader1.BackClick += pageHeader1_BackClick;
            // 
            // cmbChooseProduct
            // 
            cmbChooseProduct.BorderWidth = 2F;
            cmbChooseProduct.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbChooseProduct.Location = new Point(170, 152);
            cmbChooseProduct.Name = "cmbChooseProduct";
            cmbChooseProduct.PlaceholderText = "Choose Product";
            cmbChooseProduct.Size = new Size(298, 47);
            cmbChooseProduct.TabIndex = 0;
            // 
            // SupplierPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 117, 82);
            ClientSize = new Size(1200, 725);
            Controls.Add(pageHeader1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SupplierPage";
            Text = "SupplierPage";
            Load += SupplierPage_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSubmit;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown2;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Input input3;
        private Label label5;
        private AntdUI.Input input2;
        private Label label4;
        private AntdUI.Input input1;
        private AntdUI.Input txtContactNum;
        private Label label9;
        private AntdUI.Input txtQuantityAdd;
        private Label label6;
        private Label label8;
        private Label label7;
        private AntdUI.Select cmbChooseProduct;
        private Label label10;
        private AntdUI.Select slctCategory;
        private AntdUI.Input txtproductimage;
        private AntdUI.Input txtproductname;
        private AntdUI.Input txtproductprice;
        private AntdUI.Input txtproductdetails;
        private AntdUI.Input txtquantityrestock;
        private AntdUI.Select slctproduct;
        private Button btnsave;
    }
}