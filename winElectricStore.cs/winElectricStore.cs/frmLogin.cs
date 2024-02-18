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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtEmail.Text == "" || txtPassword.Text == "")
            //{
            //    MessageBox.Show("Emai or passwrod can't be empty");
            //}


             if (txtEmail.Text == "Worker" && txtPassword.Text == "1234")
            {
                this.Hide();
                frmWorkerDashBoard frmWorkerDashBoard = new frmWorkerDashBoard();
                //   MessageBox.Show("Welcome to Dashboard");
                frmWorkerDashBoard.ShowDialog();
                this.Close();
            }

            else if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                this.Hide();
                frmDashBoard frmDashBoard = new frmDashBoard();
                //  MessageBox.Show("Welcome to Dashboard");
                frmDashBoard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Emai or passwrod is incorrect");



                // this.Close();



            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}