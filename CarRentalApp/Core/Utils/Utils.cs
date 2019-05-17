using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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

    public static class EmailUtils
    {
        public static bool IsValidEmail(string emailAddress)
        {
            return !string.IsNullOrWhiteSpace(emailAddress)
                   && Regex.IsMatch(emailAddress,
                       @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
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
                                                  + Application.ProductName + "SqlLog.log";

        public static void LogSqlInFile(string logInfo)
        {
            File.AppendAllText(FilePath, logInfo);
        }
    }

    public class CsvUtils
    {
        public static  void SaveToCsv(DataGridView dataGridView)
        {
            var filename = string.Empty;
            var sfd = new SaveFileDialog {Filter = @"CSV (*.csv)|*.csv"};
            if (sfd.ShowDialog() != DialogResult.OK) return;
            if (File.Exists(filename))
                try
                {
                    File.Delete(filename);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(@"It wasn't possible to write the data to the disk." + ex.Message);
                }

            var columnCount = dataGridView.ColumnCount;
            var columnNames = "";
            var output = new string[dataGridView.RowCount + 1];
            for (var i = 0; i < columnCount; i++) columnNames += dataGridView.Columns[i].HeaderText + ",";
            output[0] += columnNames;
            for (var i = 1; i - 1 < dataGridView.RowCount; i++)
            for (var j = 0; j < columnCount; j++)
                output[i] += dataGridView.Rows[i - 1].Cells[j].Value + ",";
            File.WriteAllLines(sfd.FileName, output, Encoding.UTF8);
            Process.Start(sfd.FileName);
        }
    }

    public enum FormMode
    {
        View,
        Edit,
        AddNew
    }
}