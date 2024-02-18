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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWashingMachine machine = new frmWashingMachine();
            machine.ShowDialog();
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

        private void lblServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmService frmService = new frmService();   
            frmService.ShowDialog();
        }

        private void lblStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmStock frmStock =new frmStock();
            frmStock.ShowDialog();  
            
        }

        private void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void picFan_Click(object sender, EventArgs e)
        {
            this.Hide();

            //string dataToSend = "Hello from frmItems";
            frmFans frmFans = new frmFans();
            frmFans.ShowDialog();
        }

        private void picMotors_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMotors frmMotors = new frmMotors();
           frmMotors.ShowDialog();
        }
     
        private void btnSearch_Click(object sender, EventArgs e)
        {


            if (txtSearch.Text != "")
            {
                string value = txtSearch.Text;
                if (value == "motors" || value == "Motors" || value == "MOTORS")
                {
                 //   ScrollBar scrollBar = new ScrollBar();
                    groupMotor.Location = new Point(72, 44);
                   
                    groupAdd.Location = new Point(72, 257);

                    // Add a scroll bar control to the form.
                    //  scrollBar.Dock = DockStyle.Bottom;
                    //  Controls.Add(scrollBar);

                    // Set the scroll bar's minimum and maximum values.
                    //   scrollBar.Minimum = 0;
                    //   scrollBar.Maximum = 100;

                    // Set the scroll bar's small and large change values.
                    //  scrollBar.SmallChange = 1;
                    //  scrollBar.LargeChange = 10;

                    // Set the scroll bar's autoscroll property to true.
                    //  scrollBar.AutoScroll= true;
                    MessageBox.Show("Motors Found");


                }
                else if(value == "fans" || value == "Fans")
                    {
                    
                    groupFan.Location = new Point(72, 44);

                    groupAdd.Location = new Point(72, 257);
                    //  scrollBar.AutoScroll= true;
                    MessageBox.Show("Fans Found");
                }
                else if (value == "Washing Machine" || value == "washing machine")
                {
                    groupWash.Location = new Point(72, 44);

                    groupAdd.Location = new Point(461, 257);
                    //  scrollBar.AutoScroll= true;
                    MessageBox.Show("Washing Machine Found");
                }
            }

        }

        private void linklblLogOut_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void groupFan_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCategory_Click(object sender, EventArgs e)
        {
            frmaddCategory obj = new frmaddCategory();
            obj.ShowDialog();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmItems obj = new frmItems();
            obj.ShowDialog();
        }

        private void linklblLogOut_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void groupMotor_Enter(object sender, EventArgs e)
        {

        }

        private void frmItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmItems i = new frmItems();
            i.Close();
            frmDashBoard d = new frmDashBoard();
            d.Close();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {

        }

        private void frmItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmItems i = new frmItems();
            i.Close();
            frmDashBoard d = new frmDashBoard();
            d.Close();
        }

        private void frmItems_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            frmItems i = new frmItems();
            i.Dispose();
            frmDashBoard d = new frmDashBoard();
            d.Close();
        }
    }
}
