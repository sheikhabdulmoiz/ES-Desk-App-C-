using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace winElectricStore.cs
{
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
            //cmbAutoComplete.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cmbAutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //cmbAutoComplete.AutoCompleteCustomSource.AddRange(allItems.ToArray());
        }

        private void rdbHome_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.ReadOnly= false;
        }

        private void rdbShop_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAddress.ReadOnly = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\VP Asg\Data Logs Files\Services files", true);
            sw.WriteLine("====================================");
            sw.WriteLine($"Service Name: {txtServiceName.Text}");
            sw.WriteLine($"Service Name: {txtDescription.Text}");
            sw.WriteLine($"Service Name: {txtCustomerName.Text}");
            sw.WriteLine($"Service Name: {txtContact.Text}");
            if ( txtAddress.Text!="" )
                 {
                sw.WriteLine($"Service Name: {txtAddress.Text}");
            }
            sw.WriteLine("====================================");
            sw.Close();

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

        private void lblPurchase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmPurchase frmPurchase = new frmPurchase();
            frmPurchase.ShowDialog();
        }

        private void lblItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }

        private void lblStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmStock frmStock = new frmStock();
            frmStock.ShowDialog();
        }

        private void frmService_Load(object sender, EventArgs e)
        {

            {
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string qry = "select * from tblServices";
                SqlDataAdapter da = new SqlDataAdapter(qry,con);
                //SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvService.DataSource = dt;
            }

            {
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string qry = "select * from tblServices";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                //SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "SCustomerName";
            }


            //----------------------------------------------------------------------------------------------------------------

            //string connectionString = "Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True";

            //// Replace "YourTableName" with the actual name of the table containing the data
            //string query = "SELECT SCustomerName FROM tblServices WHERE SCustomerName LIKE '%"+ cmbAutoComplete.Text+ "%'"; // Modify the query
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(query, connection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable dataTable = new DataTable();

            //    try
            //    {
            //        connection.Open();
            //        adapter.Fill(dataTable);

            //        // Set the AutoComplete properties of the ComboBox
            //        cmbAutoComplete.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //        cmbAutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //        // Create a custom source for AutoComplete
            //        AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();
            //        foreach (DataRow row in dataTable.Rows)
            //        {
            //            autoCompleteSource.Add(row["SCustomerName"].ToString());
            //        }

            //        // Set the custom source for AutoComplete
            //        cmbAutoComplete.AutoCompleteCustomSource = autoCompleteSource;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}


            //====================================================================================================================
        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Report_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void linklblLogOut_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Report_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.ShowDialog();
        }

        private void lnlService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSelling frmSelling = new frmSelling();
            frmSelling.ShowDialog();
        }

        string rdbValue;
        private void rdbHome_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbHome.Checked)
            {
                rdbValue = "Home";
                txtAddress.ReadOnly = false;

            }

        }

        private void rdbShop_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbShop.Checked)
            {
                rdbValue = "Shop";
                txtAddress.ReadOnly = true;

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServiceName.Text) && !string.IsNullOrEmpty(txtCustomerName.Text) && !string.IsNullOrEmpty(rdbValue) && !string.IsNullOrEmpty(txtServiceCharges.Text))
            {


                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string sqlQuery = $"INSERT INTO tblServices (SName, SDesc, SCustomerName, SContact, SType, SAdd, SCharges) VALUES ('" + txtServiceName.Text + "','" + txtDescription.Text + "','" + txtCustomerName.Text + "','" + txtContact.Text + "','" + rdbValue + "'  ,'" + txtAddress.Text + "','" + txtServiceCharges.Text + "')";


                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("hGYA");

                //}
                // MessageBox.Show("Nh Hua");
                // else
                //{

                //}
                // SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string query = "select * from tblServices";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                //SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvService.DataSource = dt;


            }
            else
            {
                MessageBox.Show("Else Chalrha");
            }


            // end insert block

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string SName = dgvService.Rows[e.RowIndex].Cells[1].Value.ToString();

            string SCustomerName = dgvService.Rows[e.RowIndex].Cells[0].Value.ToString();

            string SDesc = dgvService.Rows[e.RowIndex].Cells[0].Value.ToString();
            string SContact = dgvService.Rows[e.RowIndex].Cells[0].Value.ToString();

            string SType = dgvService.Rows[e.RowIndex].Cells[0].Value.ToString();
            string SAdd = dgvService.Rows[e.RowIndex].Cells[0].Value.ToString();

            string SCharges = dgvService.Rows[e.RowIndex].Cells[7].Value.ToString();


            txtServiceCharges.Text = SCharges;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                //MessageBox.Show(txtSearch.Text);

                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string qry = "select * from tblServices where SName like '%" + txtSearch.Text + "%' OR SCustomerName like '%"+txtSearch.Text+ "%' OR SType like '%"+txtSearch.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvService.DataSource = dt;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string qry = "select * from tblServices";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvService.DataSource = dt;
            }
        }

        //private List<string> allItems = new List<string>
        //{
        //    "Apple",
        //    "Banana",
        //    "Cherry",
        //    "Grapes",
        //    "Kiwi",
        //    "Mango",
        //    "Orange",
        //    "Pineapple",
        //    "Strawberry",
        //    "Ammi",
        //    "Ananaas"

        //};

      

        //private void cmbAutoComplete_TextChanged(object sender, EventArgs e)
        //{
        //    string filterText = cmbAutoComplete.Text;
        //    List<string> filteredItems = allItems
        //        .Where(item => item.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))
        //        .ToList();

        //    cmbAutoComplete.BeginUpdate();
        //    cmbAutoComplete.DataSource = null;
        //    cmbAutoComplete.DataSource = filteredItems;
        //    cmbAutoComplete.DroppedDown = true;
        //    cmbAutoComplete.SelectionStart = filterText.Length;
        //    cmbAutoComplete.SelectionLength = 0;
        //    cmbAutoComplete.EndUpdate();
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvService_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbAutoComplete_TextChanged(object sender, EventArgs e)
        {
            SqlConnection coonection = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string query = "SELECT ServiceId,SCustomerName FROM tblServices WHERE SCustomerName LIKE '%" + cmbAutoComplete.Text + "%'"; // Modify the query
            SqlDataAdapter da = new SqlDataAdapter(query, coonection);
            SqlCommand cmd = new SqlCommand(query, coonection);
            DataTable dt = new DataTable();
            da.Fill(dt);
         //   cmbAutoComplete.DataSource = dt;
            //cmbAutoComplete.ValueMember = "ID";
            //   cmbAutoComplete.ValueMember"ServiceId";
          //  cmbAutoComplete.DisplayMember = "SCustomerName";



           

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
