using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winElectricStore.cs
{
    public partial class frmPurchase : Form
    {

        public void SendPurchaseData()
        {
            //Send temp to permenant table
        }

        public void SendDataToPermenantTable()
        {
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string purchaseQry = "select CategoryName, ItemName,Type,Qty, UnitPrice, TotalCost from tblPurchase ";
            SqlDataAdapter pur_da = new SqlDataAdapter(purchaseQry, con);
            DataTable pur_dt = new DataTable();
            pur_da.Fill(pur_dt);
            int pur_Count = pur_dt.Rows.Count;
            DateTime dateTime = DateTime.Now;
            for (int i = 0; i < pur_Count; i++)
            {
                string InsertQry = "insert into tblPermenant_Purchase (CName, IName,Typo,Qty, UnitPrice, TCost, Date) values ('" + pur_dt.Rows[i][0].ToString().Trim() + "','" + pur_dt.Rows[i][1].ToString().Trim() + "','" + pur_dt.Rows[i][2].ToString().Trim() + "','" + pur_dt.Rows[i][3].ToString().Trim() + "', '" + pur_dt.Rows[i][4].ToString().Trim() + "','" + pur_dt.Rows[i][5].ToString().Trim() + "', '" + dateTime + "' ) ";
                SqlCommand cmd = new SqlCommand(InsertQry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Permenant Purchase items are Inserted");
            }


        }


        public void SendDataInItem()
        {
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");

            string CheckItem = "Select itemName from tblPurchase group by itemName ORDER BY itemName ASC";
            SqlDataAdapter daCheck = new SqlDataAdapter(CheckItem, con);
            DataTable dtCheck = new DataTable();
            daCheck.Fill(dtCheck);
            int counterP = dtCheck.Rows.Count;

            for (int i = 0; i < counterP; i++)
            {
                string itemQry = "Select itemsId, itemName from tblItems";
                SqlDataAdapter daItem = new SqlDataAdapter(itemQry, con);
                DataTable dtItem = new DataTable();
                daItem.Fill(dtItem);
                int counterI = dtItem.Rows.Count;

                if (counterI > 0)
                {
                    bool itemExists = false;
                    for (int j = 0; j < counterI; j++)
                    {
                        if ((dtCheck.Rows[i][0].ToString()).Trim() == (dtItem.Rows[j][1].ToString()).Trim())
                        {
                            itemExists = true;
                            break;
                        }
                    }

                    if (!itemExists)
                    {
                        string InsertQry = "insert into tblItems(itemName) Values ('" + (dtCheck.Rows[i][0].ToString()).Trim() + "')";
                        SqlCommand cmd = new SqlCommand(InsertQry, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Item Inserted");
                    }
                }
                else
                {
                    string InsertQry = "insert into tblItems(itemName) Values ('" + (dtCheck.Rows[i][0].ToString()).Trim() + "')";
                    SqlCommand cmd = new SqlCommand(InsertQry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item Inserted");
                }
            }
        }//--------------------------------------   tblCategoryItem()
        public void tblCategoryItem()
        {
            string connectionString = "Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string qry = "Select CategoryName, itemName from tblPurchase group by CategoryName, itemName";
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string catQuery = "SELECT CategoryId FROM tblCategory WHERE CtdName = @CategoryName";
                    SqlDataAdapter catda = new SqlDataAdapter(catQuery, con);
                    catda.SelectCommand.Parameters.AddWithValue("@CategoryName", row["CategoryName"]);
                    DataTable catdt = new DataTable();
                    catda.Fill(catdt);

                    string itmQuery = "SELECT itemsId FROM tblItems WHERE itemName = @ItemName";
                    SqlDataAdapter itmda = new SqlDataAdapter(itmQuery, con);
                    itmda.SelectCommand.Parameters.AddWithValue("@ItemName", row["itemName"]);
                    DataTable itmdt = new DataTable();
                    itmda.Fill(itmdt);

                    bool idExists = false;

                    // Check if the combination of CategoryId and itemsId already exists in tblCategoryItems
                    string checkQuery = "SELECT COUNT(*) FROM tblCategoryItems WHERE CategoryId = @CategoryId AND itemsId = @ItemId";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@CategoryId", catdt.Rows[0][0]);
                        checkCmd.Parameters.AddWithValue("@ItemId", itmdt.Rows[0][0]);
                        int rowCount = (int)checkCmd.ExecuteScalar();
                        if (rowCount > 0)
                        {
                            idExists = true;
                        }
                    }

                    if (!idExists)
                    {
                        string insertQuery = "INSERT INTO tblCategoryItems (CategoryId, itemsId) VALUES (@CategoryId, @ItemId)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@CategoryId", catdt.Rows[0][0]);
                            insertCmd.Parameters.AddWithValue("@ItemId", itmdt.Rows[0][0]);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Data inserted into tblCategoryItems!");
            }
        }


        //-----------------  tbl type 
        public void SendDataInType()
        {
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");

            string CheckItem = "Select itemName, Type, CategoryName, UnitPrice from tblPurchase group by itemName, Type, CategoryName, UnitPrice";
            SqlDataAdapter daCheck = new SqlDataAdapter(CheckItem, con);
            DataTable dtCheck = new DataTable();
            daCheck.Fill(dtCheck);
            int counterP = dtCheck.Rows.Count;

            for (int i = 0; i < counterP; i++)
            {
                string itemQry = "Select TypeId, TypeName from tblType";
                SqlDataAdapter daType = new SqlDataAdapter(itemQry, con);
                DataTable dtType = new DataTable();
                daType.Fill(dtType);
                int counterI = dtType.Rows.Count;

                bool itemExists = false;
                for (int j = 0; j < counterI; j++)
                {
                    if ((dtCheck.Rows[i][1].ToString()).Trim() == (dtType.Rows[j][1].ToString()).Trim())
                    {
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    string InsertQry = "INSERT INTO tblType(TypeName, itemId, UnitPrice) " +
                                       "SELECT @TypeName, itemsId, @UnitPrice " +
                                       "FROM tblItems " +
                                       "WHERE itemName = @ItemName";

                    SqlCommand cmd = new SqlCommand(InsertQry, con);
                    cmd.Parameters.AddWithValue("@TypeName", dtCheck.Rows[i][1].ToString().Trim());
                    cmd.Parameters.AddWithValue("@ItemName", dtCheck.Rows[i][0].ToString().Trim());
                    cmd.Parameters.AddWithValue("@UnitPrice", dtCheck.Rows[i][3]); // Assuming UnitPrice is a numeric value

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Type Inserted");
                }
                else
                {
                    string qryUpdatePrice = "update tblType set UnitPrice = '" + int.Parse(dtCheck.Rows[i][3].ToString()) + "' where TypeName = '" + dtCheck.Rows[i][1].ToString().Trim() + "' ";
                    SqlCommand cmd = new SqlCommand(qryUpdatePrice, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Price Updated");
                    MessageBox.Show("Unit Price updated");

                }
            }
        }




        public frmPurchase()
        {
            InitializeComponent();
        }
        //int dist = 1;
        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCategory.Text)
            {

                case "Washing Machine":
                    {
                        x.Items.Clear();
                        string[] wmItems = new string[] { "Copper wire","Silver wire","Bush","Motor cover plates",
                            "Pully","Router","Gear box","Capacitor(4.5 uf)" ,"Capacitor (10 uf)"};
                        x.Items.AddRange(wmItems);
                    }
                    break;
                case "Motors":
                    {
                        x.Items.Clear();
                        string[] motorItems = new string[] { "Bearing", "Copper wire","Silver wire","Caluch plate",
                    "Governer switch","Capacitor (16 uf)" ,"Capacitor (20uf)","Capicitor (starting 1 hp)","Capicitor (running 1 hp)"};
                        x.Items.AddRange(motorItems);
                    }
                    break;
                case "Fans":
                    {
                        x.Items.Clear();
                        string[] fanItems = new string[] { "Copper wire","Silver wire","Bearing","wire lead",
                            "Capacitor (2.5 uf)","Capacitor (3.5 uf)","Capacitor (4.5 uf)" };
                        x.Items.AddRange(fanItems);
                    }
                    break;


            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (x.Text == "")
            {
                MessageBox.Show("Select items");

            }
            else
            {
                Label lbl = new Label();
                //listPurchase.Items.Add(x.Text);


            }
        }


        private void frmPurchase_Load(object sender, EventArgs e)
        {
            gvPurchaseData.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            Color selectedFontColor = Color.Black;
            gvPurchaseData.DefaultCellStyle.SelectionForeColor = selectedFontColor;
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select CategoryName, ItemName, Type, Qty, UnitPrice, TotalCost from tblPurchase";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            //SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvPurchaseData.DataSource = dt;

            //{
            //    SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            //    string query = "select * from tblCategory";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //   con.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        int id = dr.GetInt32(0);
            //        string cat = dr.GetString(1);
            //        cmbCategory.Items.Add(cat);
            //    }
            //    }



            //{   

            //    SqlConnection con = new SqlConnection(" Source=AHMAD333\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            //     string query = "select * from tblCategory";

            //    SqlCommand cmd = new SqlCommand(query, con);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.SelectCommand = cmd;

            //    DataTable table1 = new DataTable();

            //    da.Fill(table1);

            //    DataRow itemrow = table1.NewRow(); 
            //    //itemrow[1] = "Select product";
            //     table1.Rows.InsertAt(itemrow, 0); 

            //    cmbCategory.DataSource = table1;

            //    cmbCategory.DisplayMember="CtdName";
            //    cmbCategory.ValueMember = "CategoryId";

            //    }




            //{
            //    SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            //    string query = "select * from tblCategory";

            //    SqlCommand cmd = new SqlCommand(query, con);
            //    con.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())

            //    {
            //        //int id = dr.GetInt32(dr.GetOrdinal("Categoryid"));
            //        //string name = dr.GetString(dr.GetOrdinal("Name"));
            //        //string itemText = $"{id} - {name}"; // Customize the item text as needed
            //        //string itemText = $"{name}"; // Customize the item text as needed

            //        //cmbCategory.Items.Add(itemText);




            //    }



            //    con.Close();

            //}
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

        private void lblItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems frmItemscs = new frmItems();
            frmItemscs.ShowDialog();
        }

        private void lblServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmService frmService = new frmService();
            frmService.ShowDialog();
        }

        private void lblStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmStock frmStock = new frmStock();
            frmStock.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {


        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void linklblLogOut_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //    SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");

            //    {
            //        con.Open();

            //        // Step 2: Retrieve the data from the database
            //        string query = "SELECT ID, Name FROM YourTable"; // Replace with your actual table name and column names
            //        SqlCommand command = new SqlCommand(query, con);
            //       // SqlDataReader reader = command.ExecuteReader();
            //        SqlDataAdapter sqlDa = new SqlDataAdapter("select * from tblCategory",con);
            //        // Step 3: Populate a DataTable or collection with the retrieved data
            //        DataTable dataTable = new DataTable();
            //      //  dataTable.Load(reader);
            //        sqlDa.Fill(dataTable);                                                                                                                                                                              
            //        // Step 4: Set the combo box's DataSource property
            //        cmbCategory.DataSource = dataTable;

            //        // Step 5: Set the combo box's DisplayMember property
            //        //cmbCategory.DisplayMember = "Name";

            //        // Step 6: Optionally, set the combo box's ValueMember property
            //      //  cmbCategory.ValueMember = "ID";

            //        // Step 7: Bind the data to the combo box
            //        //cmbCategory.DataBind();
            //    }
            //try
            //{
            //MessageBox.Show(pirchaseRows.ToString());
        }

        string dbUnitPrice;

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            string ctdName, itemName, type, quant, uPrice;
            int counter;
            ctdName = cmbCategory.Text;
            itemName = cmbItem.Text;
            type = cmbType.Text;
            quant = txtQuantity.Text;
            bool flag = false;
            int getRow = 0;
            uPrice = txtUnitPrice.Text.ToString().Trim();
            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            string qry = "select CategoryName, ItemName, Type,  UnitPrice,Qty, TotalCost from tblPurchase";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            counter = dt.Rows.Count;
            // MessageBox.Show(counter.ToString());

            for (int i = 0; i < counter; i++)
            {
                //dbUnitPrice = (dt.Rows[i][3].ToString()).Trim();
                //MessageBox.Show("Unit Price: "+dbUnitPrice);
                //MessageBox.Show(dt.Rows[i][1].ToString(), ctdName);

                if (ctdName == (dt.Rows[i][0].ToString()).Trim() && itemName == (dt.Rows[i][1].ToString()).Trim() && type == (dt.Rows[i][2].ToString()).Trim())
                {
                    flag = true;
                    getRow = i;// wo row jis key teen column match krhya, ka index
                    dbUnitPrice = (dt.Rows[i][3].ToString()).Trim();
                }
                // MessageBox.Show(flag.ToString());
                else
                {
                    flag = false;
                }
                //dt.Clear();
                //MessageBox.Show("Dt clear");
            }

            if (flag == true)
            {
                //MessageBox.Show("Quantity from Combo box :" + quant);
                //MessageBox.Show("Row No. : " + getRow.ToString());
                if (dbUnitPrice == uPrice)
                {
                    // MessageBox.Show("Unit Price No. : " + uPrice.ToString());
                    // string sqlQuery = "UPDATE tblPurchase set Qty= '" + (int.Parse(dt.Rows[getRow][5].ToString()) + int.Parse(quant) + "', UnitPrice ='" + dbUnitPrice + "', TotalCost='" + ((int.Parse(dt.Rows[getRow][5].ToString()) + int.Parse(quant)) * int.Parse(dbUnitPrice))) + "' where PurchaseId='" + int.Parse(getRow.ToString()) + 1 + "'";
                    string sqlQuery = "UPDATE tblPurchase set Qty= '" + int.Parse(quant) + "', UnitPrice ='" + dbUnitPrice + "', TotalCost='" + ((int.Parse(quant)) * int.Parse(dbUnitPrice)) + "' where PurchaseId='" + int.Parse(getRow.ToString()) + 1 + "'";

                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    gvPurchaseData.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
                    Color selectedFontColor = Color.Black;
                    gvPurchaseData.DefaultCellStyle.SelectionForeColor = selectedFontColor;
                    string dataqry = "select CategoryName, ItemName, Type, Qty, UnitPrice, TotalCost from tblPurchase";
                    SqlDataAdapter data_da = new SqlDataAdapter(dataqry, con);
                    DataTable data_dt = new DataTable();
                    data_da.Fill(data_dt);
                    gvPurchaseData.DataSource = data_dt;
                    flag = false;
                    counter = 0;
                    MessageBox.Show("Old Purchase updated");

                }
                else
                {
                    MessageBox.Show("Unit price not Matched!");
                }

            }
            else
            {
                string sqlQuer = $"INSERT INTO tblPurchase (CategoryName, ItemName, Type, Qty, UnitPrice, TotalCost) VALUES ('" + cmbCategory.Text.ToString().Trim() + "','" + cmbItem.Text.ToString().Trim() + "','" + cmbType.Text.ToString().Trim() + "','" + txtQuantity.Text.ToString().Trim() + "','" + txtUnitPrice.Text.ToString().Trim() + "','" + txtCost.Text.ToString().Trim() + "')";
                SqlCommand cmd = new SqlCommand(sqlQuer, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                gvPurchaseData.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
                Color selectedFontColor = Color.Black;
                SqlConnection conReload = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
                string qryReload = "select CategoryName, ItemName, Type,  UnitPrice,Qty, TotalCost from tblPurchase";
                SqlDataAdapter daReload = new SqlDataAdapter(qryReload, con);
                DataTable dtReload = new DataTable();
                daReload.Fill(dtReload);
                gvPurchaseData.DataSource = null;
                gvPurchaseData.DataSource = dtReload;
                MessageBox.Show("New Purchase inserted successfully!");
                //MessageBox.Show(flag.ToString());

            }
            //else
            //{
            //    MessageBox.Show("Flag value not recognized");
            //}




            //------------------------------------ End 

            //cmbCategory.SelectedIndex != -1 && cmbItem.SelectedIndex != -1 && cmbType.SelectedIndex != -1 && txtQuantity.Text !="" && txtUnitPrice.Text != "" && txtCost.Text !="" 
            //if (true) 
            //{   

            //    SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");
            //    string sqlQuery = $"INSERT INTO tblPurchase (CategoryName, ItemName, Type, Qty, UnitPrice, TotalCost) VALUES ('"+ cmbCategory.Text.ToString() + "','" + cmbItem.Text.ToString() + "','" + cmbType.Text.ToString() + "','" + txtQuantity.Text + "','" + txtUnitPrice.Text + "','"+ txtCost.Text + "')";
            //    SqlCommand cmd = new SqlCommand(sqlQuery, con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Data inserted successfully!");
            //}

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

            //   SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text != "")
            {
                switch (cmbType.SelectedIndex)
                {
                    case 0:
                        txtUnitPrice.Text = "25.45";
                        break;
                    case 1:
                        txtUnitPrice.Text = "50.25";
                        break;
                    case 2:
                        txtUnitPrice.Text = "90.30";
                        break;


                }
            }
        }

        private void cmbItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }
        double qty, price;
        double tlCst;
        private object parse;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SendDataToPermenantTable();
            SendDataInItem();
            tblCategoryItem();
            SendDataInType();

            SqlConnection con = new SqlConnection("Data Source=AbdulMoiz\\SQLEXPRESS;Initial Catalog=DBElectricStore;Integrated Security=True");

            string InsertQry = " truncate table tblPurchase";
            SqlCommand cmd = new SqlCommand(InsertQry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Purchase work Completed ");


        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

            //if (txtQuantity.Text!="" && txtQuantity.Text !="." )
            //{
            //    qty = Convert.ToDouble(txtQuantity.Text);
            //    price = Convert.ToDouble(txtUnitPrice.Text);
            //    tlCst = qty * price;
            //    txtCost.Text = Convert.ToString(tlCst);
            //}


        }
    }
}
