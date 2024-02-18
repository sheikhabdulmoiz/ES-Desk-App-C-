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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void lblExplore_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
           this.Close();   
        }
        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);

        //    var timer = new System.Threading.Timer((state) =>
        //    {
        //        Form2 form2 = new Form2();
        //        form2.FormClosed += (s, args) => this.Close();
        //        form2.Show();
        //    }, null, 5000, System.Threading.Timeout.Infinite);

        //}
    }
}
