using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winElectricStore.cs
{
    public partial class frmaddCategory : Form
    {
        public frmaddCategory()
        {
            InitializeComponent();
        }

        private void frmaddCategory_Load(object sender, EventArgs e)
        {

        }


        private void BrowseImage()
        {
            // Create an OpenFileDialog object.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to Image Files.
            openFileDialog.Filter = "Image Files(.jpg; *.jpeg; *.gif; *.bmp)|.jpg; *.jpeg; *.gif; *.bmp";

            // Show the dialog box.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path to the selected image file.
                string imagePath = openFileDialog.FileName;

                // Set the Image property of the PictureBox control.
                pictureBox1.Image = new Bitmap(imagePath);

                byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseImage();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmItems obj = new frmItems();
             obj.Show();
            this.Hide();
        }
    }



}
