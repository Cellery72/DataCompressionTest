using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompressionTest
{
    public static class Utility
    {
        // Various Image to Byte Array Functions to test the difference in saving various image types
        public static byte[] ImageToByteArrayGIF(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static byte[] ImageToByteArrayPNG(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        public static byte[] ImageToByteArrayJPG(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static byte[] ImageToByteArrayBMP(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
        
        /// <summary>
        ///  Byte[] to Image Method
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns>Image represented by the incoming Byte[]</returns>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        /// <summary>
        /// Formats the value of bytes into an easily readable human string
        /// </summary>
        /// <param name="x"></param>
        /// <returns>String representing the number of bytes input</returns>
        public static string FormatValue(double x)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (x == 0)
                return "n/a";
            double bytes = Math.Abs(x);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(x) * num).ToString() + suf[place];
        }
    }
}
