using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winElectricStore.cs
{
    public partial class frmDashBoard : Form
    {
        private int childFormNumber = 0;

        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.ShowDialog();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //------------------------------------
        private void picItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmItems frmItemscs = new frmItems();
            frmItemscs.ShowDialog();

            picItems.Image = new Bitmap(picItems.Image, new Size(50, 50));
        }

        private void picPurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPurchase frmPurchase = new frmPurchase();
            frmPurchase.ShowDialog();
        }

 

        private void picStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock frmStock=new frmStock();
            frmStock.ShowDialog();
        }

        private void picService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmService frmService = new frmService();
            frmService.ShowDialog();
        }

        private void picSelling_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelling frmSelling = new frmSelling();
            frmSelling.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // FlatStyle flat = btnUpdate.FlatStyle.Flat;
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();    
        }

        private void lblService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmService frmService = new frmService();
            frmService.ShowDialog();
        }

        private void lblSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelling frmSelling = new frmSelling();
            frmSelling.ShowDialog();
        }

        private void lblPurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPurchase frmPurchase = new frmPurchase();
            frmPurchase.ShowDialog();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock frmStock = new frmStock();
            frmStock.ShowDialog();
        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void picBoxAdmin_Click(object sender, EventArgs e)
        {
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int cornerRadius = 10; // Adjust this value to control the roundness of the corners
                path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
                path.AddArc(picBoxAdmin.Width - (cornerRadius * 2), 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
                path.AddArc(picBoxAdmin.Width - (cornerRadius * 2), picBoxAdmin.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 0, 90);
                path.AddArc(0, picBoxAdmin.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90, 90);
                path.CloseFigure();

                picBoxAdmin.Region = new System.Drawing.Region(path);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCart cart = new frmCart("DashBoard");
            cart.ShowDialog();
        }

        private void frmDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmItems i = new frmItems();
            i.Close();
            frmDashBoard d = new frmDashBoard();
            d.Close();

        }

        private void frmDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmItems i = new frmItems();
            i.Close();
            frmDashBoard d = new frmDashBoard();
            d.Dispose();
        }
    }
}
