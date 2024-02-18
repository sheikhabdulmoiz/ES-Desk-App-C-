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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace winElectricStore.cs
{
    public partial class frmCart : Form
    {
        string getCategory;
        public frmCart(string cat)
        {
            InitializeComponent();
            getCategory = cat;
            //MessageBox.Show(getCategory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void gvMotorsSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void frmCart_Load(object sender, EventArgs e)
        {
            dgvCart.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            Color selectedFontColor = Color.Black;
            dgvCart.DefaultCellStyle.SelectionForeColor = selectedFontColor;
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select CartId as 'S No.', CategoryName, ItemName, Type, Qty, Subtl from tblCart";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCart.DataSource = dt;
 
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //frmCart cart = new frmCart();
            //cart.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            frmService frmService = new frmService();
            frmService.ShowDialog();
        }

        private void lblSelling_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSelling frmSelling = new frmSelling();
            frmSelling.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmPurchase frmPurchase = new frmPurchase();
            frmPurchase.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStock frmStock = new frmStock();
            frmStock.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private int cartTotal = 0; 
        private void btnTotalCart_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select Subtl from tblCart";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cartTotal = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cartTotal += Convert.ToInt32(dt.Rows[i][0]);
            }
            txtTotal.Text = cartTotal.ToString();
        }


        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string sqlQuery = $"INSERT INTO tblCustomers (Total, Date) VALUES ('" + txtTotal.Text + "','"+ dateTime + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Finalized Sell");

                string qry = "select CategoryName, ItemName, Type, Qty, Subtl from tblCart"
;
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string spQuerry = "select CustomerId from tblCustomers order by CustomerId desc";
                SqlDataAdapter cda = new SqlDataAdapter(spQuerry, con);
                DataTable cdt = new DataTable();
                cda.Fill(cdt);
                string customerId = cdt.Rows[0][0].ToString();
                

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] itemSold = new string[5];

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        itemSold[j] = dt.Rows[i][j].ToString();
                    }

                    string query = "Insert into tblItemSold (CategoryName, ItemsName, ItemType, Qty, Subtl, Date, CustomerId)  values ('" + itemSold[0].ToString() +"', '" + itemSold[1].ToString() +"', '" + itemSold[2].ToString() + "', '" + itemSold[3].ToString() + "', '" + itemSold[4].ToString() +"','"+DateTime.Now.ToString()+"','"+ customerId + "')";
                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                }

                string dltqry = "Truncate table tblCart ";
                SqlCommand delCmd = new SqlCommand(dltqry, con);
                con.Open();
                delCmd.ExecuteNonQuery();
                con.Close();
                

                string getqry = "select CategoryName, ItemName, Type, Qty, Subtl from tblCart";
                SqlDataAdapter getda = new SqlDataAdapter(getqry, con);
                //SqlCommand cmd = new SqlCommand(query, con);
                DataTable getdt = new DataTable();
                getda.Fill(getdt);
                dgvCart.DataSource = getdt;

            }
            else
            {
                MessageBox.Show("Total field is empty!");
            }

        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }

        string id;


        bool checkCell = false;

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkCell = true;
            id = dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTotal.Text = id;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (checkCell == true)
            {
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string query = "DELETE FROM tblCart WHERE CartId = '" + id + "'";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                checkCell = false;

                string qry = "select CartId as 'S No.', CategoryName, ItemName, Type, Qty, Subtl from tblCart";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCart.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Row should be selected to remove");
            }
          


        
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbGbFans_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           this.Hide();
            string getForm = "frm" + getCategory;
            Form targetForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form.Name == getForm);

            if (targetForm != null)
            {
                targetForm.Show();
            }
            else
            {
                MessageBox.Show($"Form '{getForm}' is not open.");
            }



        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
}
