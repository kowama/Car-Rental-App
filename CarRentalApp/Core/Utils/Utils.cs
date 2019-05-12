using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarRentalApp.Core.Utils
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
    public static class ImageUtils
    {
        public static byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            var image = Image.FromStream(ms);
            return image;
        }
    }


    public class AppLogger
    {
        private static readonly string FilePath = AppDomain.CurrentDomain.BaseDirectory
                                                   + Application.ProductName+"SqlLog.log";
        public static void LogSqlInFile(string logInfo)
        {
            
            File.AppendAllText(FilePath, logInfo);
        }
    }
    public enum FormMode{View, Edit, AddNew}

}
