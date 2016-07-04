using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageCryptoSandbox
{
    public class ImageHelpers
    {

        //public enum ImagingFormat
        //{
        //    bmp,
        //    jpeg,
        //    gif,
        //    tiff,
        //    png,
        //    unknown
        //}


        /// <summary>
        /// This only handles 3 types of images currently
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] GetByteArrayFromImage(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                if (image.RawFormat.Equals(ImageFormat.Bmp))
                {
                    image.Save(memoryStream, ImageFormat.Bmp);
                }
                else if (image.RawFormat.Equals(ImageFormat.Jpeg))
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                }
                else if (image.RawFormat.Equals(ImageFormat.Png))
                {
                    image.Save(memoryStream, ImageFormat.Png);
                }
                else if (image.RawFormat.Equals(ImageFormat.Gif))
                {
                    image.Save(memoryStream, ImageFormat.Gif);
                }

                return memoryStream.ToArray();
            }
        }

        public MemoryStream GetMemoryStreamFromByteArray(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(byteArray, 0, byteArray.Length);
                return ms;
            }
        }

        public static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Bitmap bm = new Bitmap(ms);

                return bm;
            }
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            //int size = (int)Math.Sqrt(byteArrayIn.Length); // Some bytes will not be used as we round down here
            int origLength = byteArrayIn.Length;
            
            int size = GetSizeOfNewArray(origLength);
            int newLength = (int)Math.Pow(size, 2);
            //byte[] augmentedArray = new byte[newLength];
            byte[] augmentedArray = Enumerable.Repeat((byte)0xff, newLength).ToArray();
            byteArrayIn.CopyTo(augmentedArray, 0);

            Bitmap bitmap = new Bitmap(size, size, PixelFormat.Format8bppIndexed);
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);

            try
            {
                // Copy byteArrayIn to bitmapData row by row (to account for the case
                // where bitmapData.Stride != bitmap.Width)
                for (int rowIndex = 0; rowIndex < bitmapData.Height; ++rowIndex)
                    //Marshal.Copy(byteArrayIn, rowIndex * bitmap.Width, bitmapData.Scan0 + rowIndex * bitmapData.Stride, bitmap.Width);
                    Marshal.Copy(augmentedArray, rowIndex * bitmap.Width, bitmapData.Scan0 + rowIndex * bitmapData.Stride, bitmap.Width);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            return bitmap;
        }

        private static int GetSizeOfNewArray(int arraySize)
        {
            double sqRt = Math.Sqrt(arraySize);
            int nextSquare = (int)Math.Floor(sqRt) + 1;
            return nextSquare;
        }


        //public static ImageFormat GetImageFormat(byte[] bytes)
        //{
        //    // see http://www.mikekunz.com/image_file_header.html  
        //    var bmp = Encoding.ASCII.GetBytes("BM");     // BMP
        //    var gif = Encoding.ASCII.GetBytes("GIF");    // GIF
        //    var png = new byte[] { 137, 80, 78, 71 };    // PNG
        //    var tiff = new byte[] { 73, 73, 42 };         // TIFF
        //    var tiff2 = new byte[] { 77, 77, 42 };         // TIFF
        //    var jpeg = new byte[] { 255, 216, 255, 224 }; // jpeg
        //    var jpeg2 = new byte[] { 255, 216, 255, 225 }; // jpeg canon

        //    if (bmp.SequenceEqual(bytes.Take(bmp.Length)))
        //        return ImageFormat.bmp;

        //    if (gif.SequenceEqual(bytes.Take(gif.Length)))
        //        return ImageFormat.gif;

        //    if (png.SequenceEqual(bytes.Take(png.Length)))
        //        return ImageFormat.png;

        //    if (tiff.SequenceEqual(bytes.Take(tiff.Length)))
        //        return ImageFormat.tiff;

        //    if (tiff2.SequenceEqual(bytes.Take(tiff2.Length)))
        //        return ImageFormat.tiff;

        //    if (jpeg.SequenceEqual(bytes.Take(jpeg.Length)))
        //        return ImageFormat.jpeg;

        //    if (jpeg2.SequenceEqual(bytes.Take(jpeg2.Length)))
        //        return ImageFormat.jpeg;

        //    return ImageFormat.unknown;
        //}
    }
}
