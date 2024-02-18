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
    public partial class frmWorkerDashBoard : Form
    {
        public frmWorkerDashBoard()
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

        private void picItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }

        private void picService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmService frmService = new frmService();
            frmService.ShowDialog();  
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }

        private void lblService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }

        private void frmWorkerDashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
