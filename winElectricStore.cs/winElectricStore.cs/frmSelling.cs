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
    public partial class frmSelling : Form
    {
        public frmSelling()
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
            frmDashBoard frmDashBoard=new frmDashBoard();   
            frmDashBoard.ShowDialog();
        }

        private void lnlService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmService frmService = new frmService();
            frmService.ShowDialog();
        }

        private void lblItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems frmItemscs = new frmItems();
            frmItemscs.ShowDialog();
        }

        private void lblPurchase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmPurchase frmPurchase = new frmPurchase();
            frmPurchase.ShowDialog();
        }

        private void lblStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmStock frmStock = new frmStock();
            frmStock.ShowDialog();
        }

        private void frmSelling_Load(object sender, EventArgs e)
        {
            gvSellingReport.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            Color selectedFontColor = Color.Black;

            // Set the font color for selected cells
            gvSellingReport.DefaultCellStyle.SelectionForeColor = selectedFontColor;
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select CustomerId as 'Customer #', Total, Date from tblCustomers";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvSellingReport.DataSource = dt;
        }

        private void linklblLogOut_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gvSellingReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string  custId = gvSellingReport.Rows[e.RowIndex].Cells[0].Value.ToString();
            //SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            //string qry = "select CategoryName, ItemsName, ItemType , Qty , Subtl from tblItemSold where CustomerId = '"+ custId + "'";
            //SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //gvSellingDetail.DataSource = dt;

        }
        string custId;
        private void gvSellingReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gvSellingDetail.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            Color selectedFontColor = Color.Black;
            // Set the font color for selected cells
            gvSellingDetail.DefaultCellStyle.SelectionForeColor = selectedFontColor;
            custId = gvSellingReport.Rows[e.RowIndex].Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select CategoryName, ItemsName, ItemType , Qty , Subtl from tblItemSold where CustomerId = '" + custId + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvSellingDetail.DataSource = dt;
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                gvSellingDetail.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
                Color selectedFontColor = Color.Black;
                // Set the font color for selected cells
                gvSellingDetail.DefaultCellStyle.SelectionForeColor = selectedFontColor;
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                //string qry = "select CategoryName, ItemsName, ItemType , Qty , Subtl from tblItemSold where CustomerId = '" + custId + "'";
                string qry = "SELECT CategoryName, ItemsName, ItemType, Qty, Subtl FROM tblItemSold WHERE (CategoryName LIKE '%" + txtSearch.Text + "%' OR ItemsName LIKE '%" + txtSearch.Text + "%' OR ItemType LIKE '%" + txtSearch.Text + "%') AND CustomerId = '" + custId + "'";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvSellingDetail.DataSource = dt;
            }
            else
            {
                gvSellingDetail.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
                Color selectedFontColor = Color.Black;
                // Set the font color for selected cells
                gvSellingDetail.DefaultCellStyle.SelectionForeColor = selectedFontColor;
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string qry = "select CategoryName, ItemsName, ItemType , Qty , Subtl from tblItemSold where CustomerId = '" + custId + "'";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvSellingDetail.DataSource = dt;
            }
        }
    }
}
