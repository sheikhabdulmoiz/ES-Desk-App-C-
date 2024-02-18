namespace winElectricStore.cs
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupAdd = new System.Windows.Forms.GroupBox();
            this.picCategory = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.groupFan = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picFan = new System.Windows.Forms.PictureBox();
            this.groupMotor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picMotors = new System.Windows.Forms.PictureBox();
            this.groupWash = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPurchase = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.lblServices = new System.Windows.Forms.LinkLabel();
            this.lblSelling = new System.Windows.Forms.LinkLabel();
            this.lblStock = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linklblLogOut = new System.Windows.Forms.LinkLabel();
            this.panel3.SuspendLayout();
            this.groupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).BeginInit();
            this.groupFan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFan)).BeginInit();
            this.groupMotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMotors)).BeginInit();
            this.groupWash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Search";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(385, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(620, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 28);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.groupAdd);
            this.panel3.Controls.Add(this.groupFan);
            this.panel3.Controls.Add(this.groupMotor);
            this.panel3.Controls.Add(this.groupWash);
            this.panel3.Location = new System.Drawing.Point(303, 126);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 583);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupAdd
            // 
            this.groupAdd.BackColor = System.Drawing.Color.Transparent;
            this.groupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupAdd.Controls.Add(this.picCategory);
            this.groupAdd.Controls.Add(this.lblAdd);
            this.groupAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupAdd.ForeColor = System.Drawing.Color.Transparent;
            this.groupAdd.Location = new System.Drawing.Point(96, 54);
            this.groupAdd.Margin = new System.Windows.Forms.Padding(4);
            this.groupAdd.Name = "groupAdd";
            this.groupAdd.Padding = new System.Windows.Forms.Padding(4);
            this.groupAdd.Size = new System.Drawing.Size(328, 254);
            this.groupAdd.TabIndex = 16;
            this.groupAdd.TabStop = false;
            // 
            // picCategory
            // 
            this.picCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCategory.Image = ((System.Drawing.Image)(resources.GetObject("picCategory.Image")));
            this.picCategory.Location = new System.Drawing.Point(13, 15);
            this.picCategory.Margin = new System.Windows.Forms.Padding(4);
            this.picCategory.Name = "picCategory";
            this.picCategory.Size = new System.Drawing.Size(297, 198);
            this.picCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCategory.TabIndex = 5;
            this.picCategory.TabStop = false;
            this.picCategory.Click += new System.EventHandler(this.picCategory_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Black;
            this.lblAdd.Location = new System.Drawing.Point(65, 217);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(193, 29);
            this.lblAdd.TabIndex = 9;
            this.lblAdd.Text = "Add new Category";
            this.lblAdd.Click += new System.EventHandler(this.picCategory_Click);
            // 
            // groupFan
            // 
            this.groupFan.BackColor = System.Drawing.Color.Transparent;
            this.groupFan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupFan.Controls.Add(this.label6);
            this.groupFan.Controls.Add(this.picFan);
            this.groupFan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupFan.Location = new System.Drawing.Point(615, 54);
            this.groupFan.Margin = new System.Windows.Forms.Padding(4);
            this.groupFan.Name = "groupFan";
            this.groupFan.Padding = new System.Windows.Forms.Padding(4);
            this.groupFan.Size = new System.Drawing.Size(327, 255);
            this.groupFan.TabIndex = 17;
            this.groupFan.TabStop = false;
            this.groupFan.Enter += new System.EventHandler(this.groupFan_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(143, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fans";
            this.label6.Click += new System.EventHandler(this.picFan_Click);
            // 
            // picFan
            // 
            this.picFan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFan.Image = ((System.Drawing.Image)(resources.GetObject("picFan.Image")));
            this.picFan.Location = new System.Drawing.Point(15, 17);
            this.picFan.Margin = new System.Windows.Forms.Padding(4);
            this.picFan.Name = "picFan";
            this.picFan.Size = new System.Drawing.Size(297, 198);
            this.picFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFan.TabIndex = 4;
            this.picFan.TabStop = false;
            this.picFan.Click += new System.EventHandler(this.picFan_Click);
            // 
            // groupMotor
            // 
            this.groupMotor.BackColor = System.Drawing.Color.Transparent;
            this.groupMotor.Controls.Add(this.label1);
            this.groupMotor.Controls.Add(this.picMotors);
            this.groupMotor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupMotor.Location = new System.Drawing.Point(96, 316);
            this.groupMotor.Margin = new System.Windows.Forms.Padding(4);
            this.groupMotor.Name = "groupMotor";
            this.groupMotor.Padding = new System.Windows.Forms.Padding(4);
            this.groupMotor.Size = new System.Drawing.Size(328, 255);
            this.groupMotor.TabIndex = 18;
            this.groupMotor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Motors";
            this.label1.Click += new System.EventHandler(this.picMotors_Click);
            // 
            // picMotors
            // 
            this.picMotors.BackColor = System.Drawing.Color.White;
            this.picMotors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMotors.Image = ((System.Drawing.Image)(resources.GetObject("picMotors.Image")));
            this.picMotors.Location = new System.Drawing.Point(13, 15);
            this.picMotors.Margin = new System.Windows.Forms.Padding(4);
            this.picMotors.Name = "picMotors";
            this.picMotors.Size = new System.Drawing.Size(297, 198);
            this.picMotors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMotors.TabIndex = 3;
            this.picMotors.TabStop = false;
            this.picMotors.Click += new System.EventHandler(this.picMotors_Click);
            // 
            // groupWash
            // 
            this.groupWash.BackColor = System.Drawing.Color.Transparent;
            this.groupWash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupWash.Controls.Add(this.label4);
            this.groupWash.Controls.Add(this.pictureBox1);
            this.groupWash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupWash.Location = new System.Drawing.Point(615, 316);
            this.groupWash.Margin = new System.Windows.Forms.Padding(4);
            this.groupWash.Name = "groupWash";
            this.groupWash.Padding = new System.Windows.Forms.Padding(4);
            this.groupWash.Size = new System.Drawing.Size(327, 255);
            this.groupWash.TabIndex = 19;
            this.groupWash.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Washing Machine";
            this.label4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPurchase
            // 
            this.lblPurchase.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblPurchase.LinkColor = System.Drawing.Color.Black;
            this.lblPurchase.Location = new System.Drawing.Point(833, 63);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(89, 25);
            this.lblPurchase.TabIndex = 4;
            this.lblPurchase.TabStop = true;
            this.lblPurchase.Text = "Purchase";
            this.lblPurchase.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lblPurchase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPurchase_LinkClicked);
            // 
            // lblHome
            // 
            this.lblHome.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblHome.LinkColor = System.Drawing.Color.Black;
            this.lblHome.Location = new System.Drawing.Point(668, 63);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(65, 25);
            this.lblHome.TabIndex = 2;
            this.lblHome.TabStop = true;
            this.lblHome.Text = "Home";
            this.lblHome.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHome_LinkClicked);
            // 
            // lblServices
            // 
            this.lblServices.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblServices.AutoSize = true;
            this.lblServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblServices.LinkColor = System.Drawing.Color.Black;
            this.lblServices.Location = new System.Drawing.Point(742, 63);
            this.lblServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(82, 25);
            this.lblServices.TabIndex = 5;
            this.lblServices.TabStop = true;
            this.lblServices.Text = "Services";
            this.lblServices.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lblServices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblServices_LinkClicked);
            // 
            // lblSelling
            // 
            this.lblSelling.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblSelling.AutoSize = true;
            this.lblSelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelling.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelling.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblSelling.LinkColor = System.Drawing.Color.Black;
            this.lblSelling.Location = new System.Drawing.Point(999, 63);
            this.lblSelling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelling.Name = "lblSelling";
            this.lblSelling.Size = new System.Drawing.Size(56, 25);
            this.lblSelling.TabIndex = 3;
            this.lblSelling.TabStop = true;
            this.lblSelling.Text = "Sales";
            this.lblSelling.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lblSelling.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelling_LinkClicked);
            // 
            // lblStock
            // 
            this.lblStock.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblStock.AutoSize = true;
            this.lblStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblStock.LinkColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(932, 63);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(61, 25);
            this.lblStock.TabIndex = 6;
            this.lblStock.TabStop = true;
            this.lblStock.Text = "Stock";
            this.lblStock.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lblStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblStock_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.lblSelling);
            this.panel2.Controls.Add(this.lblServices);
            this.panel2.Controls.Add(this.lblHome);
            this.panel2.Controls.Add(this.lblPurchase);
            this.panel2.Location = new System.Drawing.Point(263, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 103);
            this.panel2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Appliance Care Suit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.linklblLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 721);
            this.panel1.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblUser);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 316);
            this.panel4.TabIndex = 18;
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
            this.linklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogOut_LinkClicked_2);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appliance Care Suit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmItems_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmItems_FormClosed);
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupAdd.ResumeLayout(false);
            this.groupAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).EndInit();
            this.groupFan.ResumeLayout(false);
            this.groupFan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFan)).EndInit();
            this.groupMotor.ResumeLayout(false);
            this.groupMotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMotors)).EndInit();
            this.groupWash.ResumeLayout(false);
            this.groupWash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel lblPurchase;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel lblServices;
        private System.Windows.Forms.LinkLabel lblSelling;
        private System.Windows.Forms.LinkLabel lblStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linklblLogOut;
        private System.Windows.Forms.GroupBox groupAdd;
        private System.Windows.Forms.PictureBox picCategory;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.GroupBox groupFan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picFan;
        private System.Windows.Forms.GroupBox groupMotor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMotors;
        private System.Windows.Forms.GroupBox groupWash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}