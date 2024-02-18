namespace winElectricStore.cs
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltems = new System.Windows.Forms.LinkLabel();
            this.lblServices = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.lblPurchase = new System.Windows.Forms.LinkLabel();
            this.lblSelling = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linklblLogOut = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.gvGeneral = new System.Windows.Forms.DataGridView();
            this.gvDetail = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(692, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(595, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Search ";
            // 
            // lbltems
            // 
            this.lbltems.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lbltems.AutoSize = true;
            this.lbltems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbltems.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lbltems.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbltems.LinkColor = System.Drawing.Color.Black;
            this.lbltems.Location = new System.Drawing.Point(763, 63);
            this.lbltems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltems.Name = "lbltems";
            this.lbltems.Size = new System.Drawing.Size(59, 25);
            this.lbltems.TabIndex = 4;
            this.lbltems.TabStop = true;
            this.lbltems.Text = "Items";
            this.lbltems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbltems_LinkClicked);
            // 
            // lblServices
            // 
            this.lblServices.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblServices.AutoSize = true;
            this.lblServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblServices.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblServices.LinkColor = System.Drawing.Color.Black;
            this.lblServices.Location = new System.Drawing.Point(827, 63);
            this.lblServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(82, 25);
            this.lblServices.TabIndex = 5;
            this.lblServices.TabStop = true;
            this.lblServices.Text = "Services";
            this.lblServices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblServices_LinkClicked);
            // 
            // lblHome
            // 
            this.lblHome.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblHome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblHome.LinkColor = System.Drawing.Color.Black;
            this.lblHome.Location = new System.Drawing.Point(689, 63);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(65, 25);
            this.lblHome.TabIndex = 2;
            this.lblHome.TabStop = true;
            this.lblHome.Text = "Home";
            this.lblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHome_LinkClicked);
            // 
            // lblPurchase
            // 
            this.lblPurchase.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblPurchase.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblPurchase.LinkColor = System.Drawing.Color.Black;
            this.lblPurchase.Location = new System.Drawing.Point(917, 63);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(89, 25);
            this.lblPurchase.TabIndex = 6;
            this.lblPurchase.TabStop = true;
            this.lblPurchase.Text = "Purchase";
            this.lblPurchase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPurchase_LinkClicked);
            // 
            // lblSelling
            // 
            this.lblSelling.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblSelling.AutoSize = true;
            this.lblSelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelling.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lblSelling.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblSelling.LinkColor = System.Drawing.Color.Black;
            this.lblSelling.Location = new System.Drawing.Point(1014, 63);
            this.lblSelling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelling.Name = "lblSelling";
            this.lblSelling.Size = new System.Drawing.Size(56, 25);
            this.lblSelling.TabIndex = 3;
            this.lblSelling.TabStop = true;
            this.lblSelling.Text = "Sales";
            this.lblSelling.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelling_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSelling);
            this.panel2.Controls.Add(this.lblPurchase);
            this.panel2.Controls.Add(this.lblHome);
            this.panel2.Controls.Add(this.lblServices);
            this.panel2.Controls.Add(this.lbltems);
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 103);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 36);
            this.label4.TabIndex = 29;
            this.label4.Text = "Appliance Care Suit";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.linklblLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 721);
            this.panel1.TabIndex = 24;
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
            // gvGeneral
            // 
            this.gvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGeneral.Location = new System.Drawing.Point(876, 177);
            this.gvGeneral.Name = "gvGeneral";
            this.gvGeneral.RowHeadersWidth = 51;
            this.gvGeneral.RowTemplate.Height = 24;
            this.gvGeneral.Size = new System.Drawing.Size(438, 515);
            this.gvGeneral.TabIndex = 25;
            // 
            // gvDetail
            // 
            this.gvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetail.Location = new System.Drawing.Point(303, 177);
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.RowHeadersWidth = 51;
            this.gvDetail.RowTemplate.Height = 24;
            this.gvDetail.Size = new System.Drawing.Size(529, 515);
            this.gvDetail.TabIndex = 26;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.gvDetail);
            this.Controls.Add(this.gvGeneral);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appliance Care Suit";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbltems;
        private System.Windows.Forms.LinkLabel lblServices;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel lblPurchase;
        private System.Windows.Forms.LinkLabel lblSelling;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linklblLogOut;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvGeneral;
        private System.Windows.Forms.DataGridView gvDetail;
    }
}