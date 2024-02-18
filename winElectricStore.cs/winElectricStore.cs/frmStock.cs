using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winElectricStore.cs
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();

        }

        private void lblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.ShowDialog();
        }

        private void lblSelling_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSelling frmSelling = new frmSelling();
            frmSelling.ShowDialog();
        }



        private void lblServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmService frmService = new frmService();
            frmService.ShowDialog();
        }

        private void lblPurchase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmPurchase frmPurchase = new frmPurchase();
            frmPurchase.ShowDialog();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
           


            gvDetail.RowHeadersVisible = false;
         
            gvDetail.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            Color selectedFontColor = Color.Black;
            gvDetail.DefaultCellStyle.SelectionForeColor = selectedFontColor;
             SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "SELECT tblPermenant_Purchase.CName as 'Category',tblPermenant_Purchase.IName as 'Item',tblPermenant_Purchase.Typo as 'Type',tblPermenant_Purchase.Qty as 'Qty',tblItemSold.Qty as 'Sold Qty' ,tblPermenant_Purchase.Date as 'Date Purchased' FROM tblPermenant_Purchase, tblItemSold WHERE tblPermenant_Purchase.CName = tblItemSold.CategoryName AND tblPermenant_Purchase.iName = tblItemSold.ItemsName AND tblPermenant_Purchase.Typo = tblItemSold.ItemType;\r\n;";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);  
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvDetail.DataSource = dt;
        }

        private void lbltems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linklblLogOut_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }
    }
}
