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
    public partial class frmWashingMachine : Form
    {
        public frmWashingMachine()
        {
            InitializeComponent();
        }

        private void frmWashingMachine_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select tblItems.itemName from tblCategoryItems INNER JOIN tblCategory on tblCategory.CategoryId = tblCategoryItems.CategoryId inner join tblItems on tblItems.itemsId = tblCategoryItems.itemsId where CtdName = 'Washing Machine'";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstItems.DataSource = dt;
            //lstItems.ValueMember = "id";
            lstItems.DisplayMember = "itemName";
        }
        string selectedItem;
        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstItems.SelectedItems[lstItems.SelectedIndex].ToString());

            if (lstItems.SelectedIndex != -1)
            {
                selectedItem = lstItems.SelectedItem.ToString();
            }

            string imagePath = @"E:\VP Asg\images\WashingMachineParts\\" + selectedItem +".jpg";

            try
            {
                Image image = Image.FromFile(imagePath);
                picWm.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }

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

        private void lblStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmStock frmStock=new frmStock();   
            frmStock.ShowDialog();    
        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstItems.Text)
            {
                case "Motors":
                    {
                        cmbType.Items.Clear();
                        string[] motorItems = new string[] { "Bearing", "Copper wire","Silver wire","Caluch plate",
                    "Governer switch","Capacitor (16 uf)" ,"Capacitor (20uf)","Capicitor (starting 1 hp)","Capicitor (running 1 hp)"};
                        cmbType.Items.AddRange(motorItems);
                    }
                    break;
                case "Capacitor":
                    {
                        cmbType.Items.Clear();
                        string[] capictor = new string[] {"Capacitor (16 uf)" ,"Capacitor (4.5uf)","Capicitor (2.5 uf)","Capicitor (3.5 uf)"};
                        cmbType.Items.AddRange(capictor);
                    }
                    break;
                case "Gear Box":
                    {
                        cmbType.Items.Clear();
                        string[] gear = new string[] { "Ten teeth small pully", 
                            "Eleven teeth small pully", "Ten teeth large pully", "Eleven teeth large pully" };
                        cmbType.Items.AddRange(gear);
                    }
                    break;



            }
        }

        private void lstItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string lst = lstItems.Text.ToString();
            //MessageBox.Show(lstItems.Text.ToString());
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "SELECT Typo FROM tblPermenant_Purchase WHERE CName = 'Washing machine' AND IName = '" + lst + "' GROUP BY Typo";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbType.DataSource = dt;
            //cmbType.ValueMember = "TypeId";
            cmbType.DisplayMember = "Typo";
            txtQty.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string sqlQuery = $"INSERT INTO tblCart (CategoryName, ItemName, Type, Qty, Subtl) VALUES ('Washing Machine','" + lstItems.Text.ToString() + "','" + cmbType.Text + "','" + txtQty.Text + "','" + txtSubTot.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Washing Machine: items are Carted");
            }
            else
            {
                MessageBox.Show("Else Chalrha");
            }
        }

        private void txtSubTot_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close(); // Close the connection
            }

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

        private void lbCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string catValue = "WashingMachine";
            this.Hide();
            frmCart cart = new frmCart(catValue);
            cart.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }
    }
}
