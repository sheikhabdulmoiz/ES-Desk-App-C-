namespace winElectricStore.cs
{
    partial class frmDashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picService = new System.Windows.Forms.PictureBox();
            this.picSelling = new System.Windows.Forms.PictureBox();
            this.picPurchase = new System.Windows.Forms.PictureBox();
            this.picStock = new System.Windows.Forms.PictureBox();
            this.picItems = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picBoxAdmin = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.linklblLogOut = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 577);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.picItems_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 540);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Purchase";
            this.label2.Click += new System.EventHandler(this.picPurchase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(954, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selling";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 540);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stock";
            this.label6.Click += new System.EventHandler(this.picStock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Services";
            this.label5.Click += new System.EventHandler(this.picService_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.pbCart);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.picService);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.picSelling);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.picPurchase);
            this.panel4.Controls.Add(this.picStock);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.picItems);
            this.panel4.Location = new System.Drawing.Point(247, 101);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1221, 835);
            this.panel4.TabIndex = 18;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(892, 540);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cart";
            this.label9.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // pbCart
            // 
            this.pbCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Image = ((System.Drawing.Image)(resources.GetObject("pbCart.Image")));
            this.pbCart.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCart.InitialImage")));
            this.pbCart.Location = new System.Drawing.Point(765, 329);
            this.pbCart.Margin = new System.Windows.Forms.Padding(4);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(299, 202);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCart.TabIndex = 16;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(865, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sales Report";
            this.label8.Click += new System.EventHandler(this.picSelling_Click);
            // 
            // picService
            // 
            this.picService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picService.Image = ((System.Drawing.Image)(resources.GetObject("picService.Image")));
            this.picService.Location = new System.Drawing.Point(425, 33);
            this.picService.Margin = new System.Windows.Forms.Padding(4);
            this.picService.Name = "picService";
            this.picService.Size = new System.Drawing.Size(299, 246);
            this.picService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picService.TabIndex = 6;
            this.picService.TabStop = false;
            this.picService.Click += new System.EventHandler(this.picService_Click);
            // 
            // picSelling
            // 
            this.picSelling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSelling.Image = ((System.Drawing.Image)(resources.GetObject("picSelling.Image")));
            this.picSelling.Location = new System.Drawing.Point(765, 33);
            this.picSelling.Margin = new System.Windows.Forms.Padding(4);
            this.picSelling.Name = "picSelling";
            this.picSelling.Size = new System.Drawing.Size(303, 243);
            this.picSelling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelling.TabIndex = 8;
            this.picSelling.TabStop = false;
            this.picSelling.Click += new System.EventHandler(this.picSelling_Click);
            // 
            // picPurchase
            // 
            this.picPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPurchase.Image = global::winElectricStore.cs.Properties.Resources.Purchase;
            this.picPurchase.Location = new System.Drawing.Point(425, 329);
            this.picPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.picPurchase.Name = "picPurchase";
            this.picPurchase.Size = new System.Drawing.Size(299, 202);
            this.picPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPurchase.TabIndex = 5;
            this.picPurchase.TabStop = false;
            this.picPurchase.Click += new System.EventHandler(this.picPurchase_Click);
            // 
            // picStock
            // 
            this.picStock.BackColor = System.Drawing.Color.Transparent;
            this.picStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStock.Image = ((System.Drawing.Image)(resources.GetObject("picStock.Image")));
            this.picStock.Location = new System.Drawing.Point(38, 328);
            this.picStock.Margin = new System.Windows.Forms.Padding(4);
            this.picStock.Name = "picStock";
            this.picStock.Size = new System.Drawing.Size(344, 203);
            this.picStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStock.TabIndex = 7;
            this.picStock.TabStop = false;
            this.picStock.Click += new System.EventHandler(this.picStock_Click);
            // 
            // picItems
            // 
            this.picItems.BackColor = System.Drawing.Color.White;
            this.picItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picItems.ErrorImage = null;
            this.picItems.Image = ((System.Drawing.Image)(resources.GetObject("picItems.Image")));
            this.picItems.ImageLocation = "";
            this.picItems.InitialImage = null;
            this.picItems.Location = new System.Drawing.Point(38, 30);
            this.picItems.Margin = new System.Windows.Forms.Padding(4);
            this.picItems.Name = "picItems";
            this.picItems.Size = new System.Drawing.Size(344, 244);
            this.picItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItems.TabIndex = 4;
            this.picItems.TabStop = false;
            this.picItems.Click += new System.EventHandler(this.picItems_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.picBoxAdmin);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 257);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoEllipsis = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(51, 267);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // picBoxAdmin
            // 
            this.picBoxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAdmin.ImageLocation = "";
            this.picBoxAdmin.Location = new System.Drawing.Point(67, 34);
            this.picBoxAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxAdmin.Name = "picBoxAdmin";
            this.picBoxAdmin.Size = new System.Drawing.Size(133, 113);
            this.picBoxAdmin.TabIndex = 0;
            this.picBoxAdmin.TabStop = false;
            this.picBoxAdmin.Click += new System.EventHandler(this.picBoxAdmin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 188);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Admin";
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
            // linklblLogOut
            // 
            this.linklblLogOut.ActiveLinkColor = System.Drawing.Color.Gold;
            this.linklblLogOut.AutoSize = true;
            this.linklblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblLogOut.DisabledLinkColor = System.Drawing.Color.Gray;
            this.linklblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLogOut.ForeColor = System.Drawing.Color.Red;
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
            this.linklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogOut_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.linklblLogOut);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 719);
            this.panel1.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.AllowDrop = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(250, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel5.Size = new System.Drawing.Size(1094, 103);
            this.panel5.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Dashboard";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(279, 36);
            this.label14.TabIndex = 29;
            this.label14.Text = "Appliance Care Suit";
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appliance Care Suit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashBoard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox picSelling;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picStock;
        private System.Windows.Forms.PictureBox picPurchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxAdmin;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linklblLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}



