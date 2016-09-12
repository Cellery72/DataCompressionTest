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

namespace DataCompressionTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // step 1 
            // convert image to byte [], update lbl current image and lbl byte[] 
            // step 2 compress byte array and update lbl
            // step 3 change picturebox to represent the uploaded image


            int size = -1;

            DialogResult result = ofDialog.ShowDialog(); // Show the dialog... hope for a response from the user
            if (result == DialogResult.OK)
            {
                string file = ofDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine("Error opening file");



            lblCurrentImage.Text = size.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearContents();
        }
        private void ClearContents()
        {
            lblCompressedByte.Text = "n/a";
            lblCurrentByte.Text = "n/a";
            lblCurrentImage.Text = "n/a";
            pbCurrentImage.BackgroundImage = null;
        }
    }
}

