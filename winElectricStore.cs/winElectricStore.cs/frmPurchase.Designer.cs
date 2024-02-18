namespace winElectricStore.cs
{
    partial class frmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase));
            this.lblSelling = new System.Windows.Forms.LinkLabel();
            this.lblStock = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.lblServices = new System.Windows.Forms.LinkLabel();
            this.lblItems = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPurchaseForm = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.x = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.gvPurchaseData = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linklblLogOut = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPurchaseForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchaseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelling
            // 
            this.lblSelling.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblSelling.AutoSize = true;
            this.lblSelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelling.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblSelling.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblSelling.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblSelling.LinkColor = System.Drawing.Color.Black;
            this.lblSelling.Location = new System.Drawing.Point(1019, 63);
            this.lblSelling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelling.Name = "lblSelling";
            this.lblSelling.Size = new System.Drawing.Size(56, 25);
            this.lblSelling.TabIndex = 3;
            this.lblSelling.TabStop = true;
            this.lblSelling.Text = "Sales";
            this.lblSelling.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelling_LinkClicked);
            // 
            // lblStock
            // 
            this.lblStock.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblStock.AutoSize = true;
            this.lblStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStock.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblStock.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblStock.LinkColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(952, 63);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(61, 25);
            this.lblStock.TabIndex = 6;
            this.lblStock.TabStop = true;
            this.lblStock.Text = "Stock";
            this.lblStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblStock_LinkClicked);
            // 
            // lblHome
            // 
            this.lblHome.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblHome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblHome.LinkColor = System.Drawing.Color.Black;
            this.lblHome.Location = new System.Drawing.Point(718, 63);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(65, 25);
            this.lblHome.TabIndex = 2;
            this.lblHome.TabStop = true;
            this.lblHome.Text = "Home";
            this.lblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHome_LinkClicked);
            // 
            // lblServices
            // 
            this.lblServices.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblServices.AutoSize = true;
            this.lblServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblServices.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblServices.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblServices.LinkColor = System.Drawing.Color.Black;
            this.lblServices.Location = new System.Drawing.Point(862, 63);
            this.lblServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(82, 25);
            this.lblServices.TabIndex = 5;
            this.lblServices.TabStop = true;
            this.lblServices.Text = "Services";
            this.lblServices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblServices_LinkClicked);
            // 
            // lblItems
            // 
            this.lblItems.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblItems.AutoSize = true;
            this.lblItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItems.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblItems.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblItems.LinkColor = System.Drawing.Color.Black;
            this.lblItems.Location = new System.Drawing.Point(795, 63);
            this.lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(59, 25);
            this.lblItems.TabIndex = 4;
            this.lblItems.TabStop = true;
            this.lblItems.Text = "Items";
            this.lblItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblItems_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPurchaseForm);
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Location = new System.Drawing.Point(299, 121);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 593);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPurchaseForm
            // 
            this.tabPurchaseForm.Controls.Add(this.groupBox1);
            this.tabPurchaseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPurchaseForm.Location = new System.Drawing.Point(4, 25);
            this.tabPurchaseForm.Margin = new System.Windows.Forms.Padding(4);
            this.tabPurchaseForm.Name = "tabPurchaseForm";
            this.tabPurchaseForm.Padding = new System.Windows.Forms.Padding(4);
            this.tabPurchaseForm.Size = new System.Drawing.Size(1028, 564);
            this.tabPurchaseForm.TabIndex = 0;
            this.tabPurchaseForm.Text = "Purchase Form";
            this.tabPurchaseForm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbItem);
            this.groupBox1.Controls.Add(this.x);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(259, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(514, 501);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Entry";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Items.AddRange(new object[] {
            "erer",
            "rer"});
            this.cmbItem.Location = new System.Drawing.Point(203, 130);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(240, 33);
            this.cmbItem.Sorted = true;
            this.cmbItem.TabIndex = 4;
            // 
            // x
            // 
            this.x.AllowDrop = true;
            this.x.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.x.FormattingEnabled = true;
            this.x.Items.AddRange(new object[] {
            "Capicitor",
            "Wire",
            "Gear Box"});
            this.x.Location = new System.Drawing.Point(70, 428);
            this.x.Margin = new System.Windows.Forms.Padding(4);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(240, 33);
            this.x.TabIndex = 4;
            this.x.SelectedIndexChanged += new System.EventHandler(this.cmbItems_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(80, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbType
            // 
            this.cmbType.AllowDrop = true;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "capacit",
            "capacitor",
            "capacitoraa"});
            this.cmbType.Location = new System.Drawing.Point(203, 189);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(240, 33);
            this.cmbType.TabIndex = 16;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(79, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(204, 301);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(240, 30);
            this.txtUnitPrice.TabIndex = 14;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(332, 424);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 37);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(79, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(79, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(80, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(79, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(203, 73);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(240, 33);
            this.cmbCategory.Sorted = true;
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged_1);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(203, 354);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(240, 30);
            this.txtCost.TabIndex = 2;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(203, 246);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(240, 30);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.btnSave);
            this.tabSummary.Controls.Add(this.gvPurchaseData);
            this.tabSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSummary.Location = new System.Drawing.Point(4, 25);
            this.tabSummary.Margin = new System.Windows.Forms.Padding(4);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(4);
            this.tabSummary.Size = new System.Drawing.Size(1028, 564);
            this.tabSummary.TabIndex = 1;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(433, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gvPurchaseData
            // 
            this.gvPurchaseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPurchaseData.Location = new System.Drawing.Point(33, 20);
            this.gvPurchaseData.Name = "gvPurchaseData";
            this.gvPurchaseData.RowHeadersWidth = 51;
            this.gvPurchaseData.RowTemplate.Height = 24;
            this.gvPurchaseData.Size = new System.Drawing.Size(969, 449);
            this.gvPurchaseData.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoEllipsis = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(51, 267);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Muhammad Talha";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(105, 188);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 18);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(67, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 113);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 316);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.linklblLogOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 721);
            this.panel2.TabIndex = 20;
            // 
            // linklblLogOut
            // 
            this.linklblLogOut.ActiveLinkColor = System.Drawing.Color.Gold;
            this.linklblLogOut.AutoSize = true;
            this.linklblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblLogOut.LinkColor = System.Drawing.Color.Black;
            this.linklblLogOut.Location = new System.Drawing.Point(79, 667);
            this.linklblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblLogOut.Name = "linklblLogOut";
            this.linklblLogOut.Size = new System.Drawing.Size(84, 25);
            this.linklblLogOut.TabIndex = 20;
            this.linklblLogOut.TabStop = true;
            this.linklblLogOut.Text = "Log out";
            this.linklblLogOut.VisitedLinkColor = System.Drawing.Color.Black;
            this.linklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogOut_LinkClicked_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lblSelling);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblServices);
            this.panel4.Controls.Add(this.lblItems);
            this.panel4.Controls.Add(this.lblStock);
            this.panel4.Controls.Add(this.lblHome);
            this.panel4.Location = new System.Drawing.Point(256, -1);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 103);
            this.panel4.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Purchase";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 36);
            this.label9.TabIndex = 29;
            this.label9.Text = "Appliance Care Suit";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appliance Care Suit";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPurchaseForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchaseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblSelling;
        private System.Windows.Forms.LinkLabel lblStock;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel lblServices;
        private System.Windows.Forms.LinkLabel lblItems;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPurchaseForm;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linklblLogOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox x;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.DataGridView gvPurchaseData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}