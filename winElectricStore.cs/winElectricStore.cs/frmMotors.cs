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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winElectricStore.cs
{
    public partial class frmMotors : Form
    {
        string lst;

        public frmMotors()
        {

            InitializeComponent();
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

        private void frmMotors_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select tblItems.itemName from tblCategoryItems INNER JOIN tblCategory on tblCategory.CategoryId = tblCategoryItems.CategoryId inner join tblItems on tblItems.itemsId = tblCategoryItems.itemsId where CtdName = 'Motors'";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstItems.DataSource = dt;
            //lstItems.ValueMember = "id";
            lstItems.DisplayMember = "itemName";

            //gvMotorsSummary.Rows[0].Cells[3].Value="Talha";


            //string datatosend = lstItems.Text.ToString();
            //frmFans obj = new frmFans(datatosend);
        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst = lstItems.Text.ToString();
            //MessageBox.Show(lstItems.Text.ToString());
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            //MessageBox.Show(lst);
            //string qry = "select tblItems.ItemName, tblType.TypeName from tblItems inner join tblType  on tblItems.itemsId=tblType.ItemId where itemName = '" + lst  + "'";
            string qry = "SELECT Typo FROM tblPermenant_Purchase WHERE CName = 'Motors' AND IName = '" + lst + "' GROUP BY Typo";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbType.DataSource = dt;
            //cmbType.ValueMember = "TypeId";
            cmbType.DisplayMember = "Typo";
            txtQty.Text = "";


            //this.Hide();

        }

        //public static string DataToSend = lst;


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
            this.Hide();
            frmStock frmStock = new frmStock();
            frmStock.ShowDialog();

        }

        private void linklblLogOut_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //int count = 0;

        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string sqlQuery = $"INSERT INTO tblCart (CategoryName, ItemName, Type, Qty, Subtl) VALUES ('Motors','" + lstItems.Text.ToString() + "','" + cmbType.Text + "','" + txtQty.Text + "','" + txtSubTot.Text + "')";
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

                MessageBox.Show("Motor items are Carted");



            }
            else
            {
                MessageBox.Show("Else Chalrha");
            }















            //    if(txtQty.Text!="" && txtUnitPrice.Text != "")
            //    {

            //        gvMotorsSummary.Rows.Add();
            //        gvMotorsSummary.Rows[count].Cells[0].Value=lstItems.Text.ToString();
            //        gvMotorsSummary.Rows[count].Cells[1].Value = cmbType.Text.ToString();
            //        gvMotorsSummary.Rows[count].Cells[2].Value = txtQty.Text;
            //        gvMotorsSummary.Rows[count].Cells[3].Value = txtSubTot.Text;
            //        //gvMotorsSummary.Rows[count].Cells[4].Value = txtSubTot.Text;
            //        DateTime dateTime = DateTime.Now;
            //        string formattedDateTime = dateTime.ToString("hh:mm tt || d/M/yyyy");
            //        gvMotorsSummary.Rows[count].Cells[5].Value = formattedDateTime;



            //        MessageBox.Show("Data Added");
            //        count++;


            //    }
        }

        private void gvMotorsSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int counter = 0;
        string cntPer;
        private void btnSave_Click(object sender, EventArgs e)
        {
            counter++;
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string countid = "CS" + counter.ToString(); // Remove the extra single quotes
            string qry = "insert into tblCustomers (CustomerId) values ('" + countid + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string catValue = "Motors";
            this.Hide();
            frmCart cart = new frmCart(catValue);
            cart.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }
    }


}
