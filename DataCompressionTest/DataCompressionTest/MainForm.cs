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
    // step 1 
    // convert image to byte [], update lbl current image and lbl byte[] 
    // step 2 compress byte array and update lbl
    // step 3 change picturebox to represent the uploaded image

    public partial class MainForm : Form
    {
        private double imageSize, byteSize, compressedByteSize, quickLZCompressionSize;
        private Image currentImage = null;
        
        public MainForm()
        {
            InitializeComponent();
        }

        // Event Handlers
        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = ofDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    // set the currentImage to that opened in the file dialog
                    currentImage = Image.FromFile(ofDialog.FileName);
                    imageSize = new FileInfo(ofDialog.FileName).Length;
                    GenerateValues(currentImage);
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine("Error opening file");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValues();
        }
        
        // Private functions to UPDATE the view, GENERATE the values based on the currentImage
        // and CLEAR the exsisting values        
        private void ClearValues()
        {
            lblCompressedByte.Text = "n/a";
            lblCurrentByte.Text = "n/a";
            lblCurrentImage.Text = "n/a";
            pbCurrentImage.BackgroundImage = null;
        }
        private void UpdateValues()
        {
            // Update values of Labels
            lblCurrentImage.Text = Utility.FormatValue(imageSize);
            lblCurrentByte.Text = Utility.FormatValue(byteSize);
            lblCompressedByte.Text = Utility.FormatValue(compressedByteSize);
            lblQuickLZ.Text = Utility.FormatValue(quickLZCompressionSize);
            // Update PictureBox
            if (currentImage != null)
                pbCurrentImage.BackgroundImage = currentImage;
        }
        private void GenerateValues(Image img)
        {
            // Regular byte[]
            byte[] normalByteArray = Utility.ImageToByteArray(img);
            byteSize = normalByteArray.Length;
            
            // Quick LZ Compression
            byte[] compressedByteArray = QuickLZ.compress(normalByteArray,1);
            compressedByteSize = compressedByteArray.Length;
            
            UpdateValues();
        }
    }
}

