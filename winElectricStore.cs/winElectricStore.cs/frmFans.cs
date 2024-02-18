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

    public partial class frmFans : Form
    {
        //string dataRecieved;
        public frmFans()
        {
            InitializeComponent();
            //dataRecieved = datatosend;
            //cmbType.Text = dataRecieved;
            //dataRecieved = data;


        }

        private void lblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.ShowDialog();
        }

        private void lnlService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmService frmService = new frmService();
            frmService.ShowDialog();
        }

        private void lbltems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
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

        private void frmFans_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select tblItems.itemName from tblCategoryItems INNER JOIN tblCategory on tblCategory.CategoryId = tblCategoryItems.CategoryId inner join tblItems on tblItems.itemsId = tblCategoryItems.itemsId where CtdName = 'Fans'";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstItems.DataSource = dt;
            //lstItems.ValueMember = "id";
            lstItems.DisplayMember = "itemName";
        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lst = lstItems.Text.ToString();
            //MessageBox.Show(lstItems.Text.ToString());
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "SELECT Typo FROM tblPermenant_Purchase WHERE CName = 'Fans' AND IName = '" + lst + "' GROUP BY Typo";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbType.DataSource = dt;
            //cmbType.ValueMember = "TypeId";
            cmbType.DisplayMember = "Typo";
            txtQty.Text = "";
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "SELECT UnitPrice FROM tblType WHERE TypeName = @TypeName";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@TypeName", cmbType.Text);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // Convert the retrieved value to the appropriate data type (e.g., double, decimal, etc.)
                    double unitPrice = Convert.ToDouble(result);
                    txtUnitPrice.Text = unitPrice.ToString(); // Display the UnitPrice in the txtUnitPrice TextBox
                }
                else
                {
                    // Handle the case when no matching record is found
                    txtUnitPrice.Text = "Not Found";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the database operation
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close(); // Close the connection
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtQty.Text != "" && txtUnitPrice.Text != "")
                {
                    // MessageBox.Show(txtUnitPrice.Text);
                    double unit = double.Parse(txtUnitPrice.Text);
                    double qty = double.Parse(txtQty.Text);
                    double subTot = unit * qty;
                    txtSubTot.Text = subTot.ToString();
                }
                else
                {
                    txtSubTot.Text = "";

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string sqlQuery = $"INSERT INTO tblCart (CategoryName, ItemName, Type, Qty, Subtl) VALUES ('Fans','" + lstItems.Text.ToString() + "','" + cmbType.Text + "','" + txtQty.Text + "','" + txtSubTot.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                //string query = "select CategoryName, ItemName, Type, Qty, Subtl from tblCart";
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                ////SqlCommand cmd = new SqlCommand(query, con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dgvCart.DataSource = dt;

                MessageBox.Show("Fan items are Carted");



            }
            else
            {
                MessageBox.Show("Else Chalrha");
            }
        }

        public string prevCategory(string cat)
        {
            return cat; 
        }

        private void lbCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           string catValue = "Fans";
            this.Hide();
            frmCart cart = new frmCart(prevCategory(catValue));
            cart.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
