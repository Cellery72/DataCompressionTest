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
        // define private variables
        private double imageSize;
        private byte[] normalByteArrayGIF, normalByteArrayJPG, normalByteArrayBMP, normalByteArrayPNG;
        private Image currentImage = null;
        
        public MainForm()
        {
            InitializeComponent();
        }

        // Event Handlers
        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Show Dialog and hope for response
            DialogResult result = ofDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    // set the currentImage to that opened in the file dialog, populate the Image Size label
                    currentImage = Image.FromFile(ofDialog.FileName);
                    
                    // Update teh file name
                    lblFile.Text = ofDialog.SafeFileName;
                    imageSize = new FileInfo(ofDialog.FileName).Length;

                    // Generate the values based on the currentImage
                    GenerateValues(currentImage);
                    
                    // Update the values
                    UpdateValues();
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
            foreach(Control c in Controls)
            {
                if (c.Tag!= null && c.Tag == "clear")
                {
                    var label = (Label)c;
                    label.Text = "n/a";
                }
            }
            pbCurrentImage.BackgroundImage = null;
        }
        private void UpdateValues()
        {
            // Update values of Labels
            lblCurrentImage.Text = Utility.FormatValue(imageSize);

            lblCurrentPNG.Text = Utility.FormatValue(normalByteArrayPNG.Length);
            lblCurrentGIF.Text = Utility.FormatValue(normalByteArrayGIF.Length);
            lblCurrentJPG.Text = Utility.FormatValue(normalByteArrayJPG.Length);
            lblCurrentBMP.Text = Utility.FormatValue(normalByteArrayBMP.Length);

            lblQuickLZBMP.Text = Utility.FormatValue(QuickLZ.compress(normalByteArrayBMP,1).Length);
            lblQuickLZJPG.Text = Utility.FormatValue(QuickLZ.compress(normalByteArrayJPG, 1).Length);
            lblQuickLZGIF.Text = Utility.FormatValue(QuickLZ.compress(normalByteArrayGIF, 1).Length);
            lblQuickLZPNG.Text = Utility.FormatValue(QuickLZ.compress(normalByteArrayPNG, 1).Length);
            
            // Update PictureBox
            if (currentImage != null)
                pbCurrentImage.BackgroundImage = currentImage;
        }
        private void GenerateValues(Image img)
        {
            // Create multiple byte arrays from various image types
            normalByteArrayGIF = Utility.ImageToByteArrayGIF(img);
            normalByteArrayPNG = Utility.ImageToByteArrayPNG(img);
            normalByteArrayBMP = Utility.ImageToByteArrayBMP(img);
            normalByteArrayJPG = Utility.ImageToByteArrayJPG(img);            
        }
    }
}

