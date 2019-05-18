using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Font = iTextSharp.text.Font;
using Image = System.Drawing.Image;

namespace CarRentalApp.Core.Utils
{
    public enum FormMode
    {
        View,
        Edit,
        AddNew
    }

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

    public class ExportUtils
    {
        public static void ToCsv(DataGridView dataGridView, string defaultFileName = "Client List")
        {
            var sfd = new SaveFileDialog
            {
                Filter = @"CSV (*.csv)|*.csv",
                FileName = $"{defaultFileName} {DateTime.Now:dd-MM-yyyy hh-mmm-ss}"
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            try
            {
                var columnNames = string.Empty;
                var output = new string[dataGridView.RowCount + 1];

                for (var i = 0; i < dataGridView.ColumnCount; i++)
                    columnNames += dataGridView.Columns[i].HeaderText + ",";

                output[0] += columnNames;

                for (var i = 1; i <= dataGridView.RowCount - 1; i++)
                for (var j = 0; j < dataGridView.ColumnCount; j++)
                    output[i] += dataGridView[j, i - 1].Value + ",";


                File.WriteAllLines(sfd.FileName, output, Encoding.UTF8);

                Process.Start(sfd.FileName);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ToPdf(DataGridView dataGridView, string headerString = "Client List")
        {
            try
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = @"Document PDF (*.pdf)|*.pdf",
                    FileName = $"{headerString} {DateTime.Now:dd-MM-yyyy hh-mmm-ss}"
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                var doc = new Document(PageSize.A4.Rotate(), 15, 15, 20, 20);
                var file = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                var writer = PdfWriter.GetInstance(doc, file);

                doc.Open();

                //left-header
                var leftHeaderParagraph = new Paragraph {Alignment = Element.ALIGN_LEFT};
                //logo
                var logo = iTextSharp.text.Image.GetInstance(Resources.app_logo_black, BaseColor.WHITE);
                var brandName = new Chunk("Rent Luxury");
                leftHeaderParagraph.Add(logo);
                leftHeaderParagraph.Add(brandName);
                doc.Add(leftHeaderParagraph);

                //Report Header
                var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                var headFont = new Font(baseFont, 16, 1, BaseColor.GRAY);
                var prgHeading = new Paragraph
                {
                    Alignment = Element.ALIGN_CENTER
                };
                prgHeading.Add(new Chunk(headerString.ToUpper(), headFont));
                doc.Add(prgHeading);

                //Author
                var authorParagraph = new Paragraph();
                var authorBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                var authorFont = new Font(authorBaseFont, 10, 2, BaseColor.GRAY);
                authorParagraph.Alignment = Element.ALIGN_RIGHT;
                authorParagraph.Add(new Chunk($"Author : {Program.CurrentUser.FullName}", authorFont));
                authorParagraph.Add(new Chunk("\nDate : " + DateTime.Now.ToShortDateString(), authorFont));
                doc.Add(authorParagraph);

                //Add a line separation
                var p = new Paragraph(new Chunk(new LineSeparator(0.0F, 100.0F, BaseColor.GRAY, Element.ALIGN_LEFT,
                    1)));
                doc.Add(p);

                //Add line break
                doc.Add(new Chunk("\n", headFont));

                //Write the table
                var table = new PdfPTable(dataGridView.ColumnCount);

                //Table header
                var tableBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                var headerFont = new Font(tableBaseFont, 12, 1, BaseColor.WHITE);
                for (var i = 0; i < dataGridView.Columns.Count; i++)
                {
                    var cell = new PdfPCell
                    {
                        BackgroundColor = BaseColor.GRAY,
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_CENTER,
                        Padding = 8
                    };
                    cell.AddElement(new Chunk(dataGridView.Columns[i].HeaderText, headerFont));

                    table.AddCell(cell);
                }

                //table Data
                for (var i = 0; i < dataGridView.Rows.Count; i++)
                for (var j = 0; j < dataGridView.Columns.Count; j++)
                {
                    var contentFont = new Font(tableBaseFont, 10, 0, BaseColor.BLACK);

                    var cell = new PdfPCell
                    {
                        BorderColor = BaseColor.GRAY,
                        PaddingLeft = 4,
                        PaddingTop = 8,
                        PaddingBottom = 8,
                        BackgroundColor = i % 2 == 0 ? new BaseColor(Color.FromArgb(216, 218, 216)) : BaseColor.WHITE,
                        VerticalAlignment = Element.ALIGN_LEFT,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    cell.AddElement(new Chunk(dataGridView[j, i].FormattedValue?.ToString(), contentFont));
                    table.AddCell(cell);
                }

                doc.Add(table);
                doc.Close();

                writer.Close();

                doc.Close();
                Process.Start(saveFileDialog.FileName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ToPdf(Bill bill)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = @"Document PDF (*.pdf)|*.pdf",
                    FileName = $"bill {DateTime.Now:dd-MM-yyyy hh-mmm-ss}"
                };
                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
                var doc = new Document(PageSize.A4, 50, 50, 25, 25);
                var file = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                var writer = PdfWriter.GetInstance(doc, file);

                doc.Open();

                var titleFont = FontFactory.GetFont("Arial", 18, Font.BOLD);
//                var subTitleFont = FontFactory.GetFont("Arial", 14, Font.BOLD);
                var boldTableFont = FontFactory.GetFont("Arial", 12, Font.BOLD);
                var endingMessageFont = FontFactory.GetFont("Arial", 10, Font.ITALIC);
                var bodyFont = FontFactory.GetFont("Arial", 12, Font.NORMAL);

                //left-header
                var leftHeaderParagraph = new Paragraph {Alignment = Element.ALIGN_LEFT};
                //logo
                var logo = iTextSharp.text.Image.GetInstance(Resources.app_logo_black, BaseColor.WHITE);
                var brandName = new Chunk("Rent Luxury");
                leftHeaderParagraph.Add(logo);
                leftHeaderParagraph.Add(brandName);
                doc.Add(leftHeaderParagraph);

                doc.Add(new Paragraph(bill.Date.ToString("dd/MM/yyyy"), bodyFont) {Alignment = Element.ALIGN_RIGHT});

                doc.Add(new Paragraph("Rent Luxury Receipt", titleFont) {Alignment = Element.ALIGN_CENTER});
                //body
                var billBody = new PdfPTable(2)
                {
                    HorizontalAlignment = 0, SpacingBefore = 10, SpacingAfter = 10,
                    WidthPercentage = 100
                };
                billBody.DefaultCell.Border = 0;
                billBody.SetWidths(new[] {2, 6});

                billBody.AddCell(new Phrase("Bill Num:", boldTableFont));
                billBody.AddCell(bill.BillNumber.ToString("D").ToUpper());
                billBody.AddCell(new Phrase("Rent Id:", boldTableFont));
                billBody.AddCell(bill.Rent.RentId.ToString("D").ToUpper());
                billBody.AddCell(new Phrase("Customer Name:", boldTableFont));
                billBody.AddCell(bill.Rent.Client.FullName);
                billBody.AddCell(new Phrase("Customer CIN:", boldTableFont));
                billBody.AddCell(bill.Rent.Client.Cin);
                billBody.AddCell(new Phrase("Car Name:", boldTableFont));
                billBody.AddCell(bill.Rent.Car.Name);
                billBody.AddCell(new Phrase("Car License Plate:", boldTableFont));
                billBody.AddCell(bill.Rent.Car.LicensePlate);
                billBody.AddCell(new Phrase("Managed By:", boldTableFont));
                billBody.AddCell(bill.Rent.ManageBy.FullName);
                billBody.AddCell(new Phrase("Rent Date Start:", boldTableFont));
                billBody.AddCell(bill.Rent.DateStart.ToString("dd/MM/yyyy"));
                billBody.AddCell(new Phrase("Rent Date End:", boldTableFont));
                billBody.AddCell(bill.Rent.DateEnd?.ToString("dd/MM/yyyy"));
                billBody.AddCell(new Phrase("Amount:", boldTableFont));
                billBody.AddCell($"{bill.Amount:N0} MAD");
                billBody.AddCell(new Phrase("Details:", boldTableFont));
                billBody.AddCell(bill.Details);
                billBody.AddCell(bill.Date.ToString("dd/MM/yyyy"));
                doc.Add(billBody);

                doc.Add(new Paragraph("Thanks for taking rent with us", endingMessageFont)
                    {Alignment = Element.ALIGN_LEFT});


                doc.Close();
                writer.Close();

                Process.Start(saveFileDialog.FileName);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Resources.ToPdf_Pdf_Generation_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }



    public static class Cipher
    {
       
        
        public static string Encrypt(string plainText, string password="secureSHa256")
        {
            if (plainText == null) return null;

            if (password == null) password = string.Empty;

            // Get the bytes of the string
            var bytesToBeEncrypted = Encoding.UTF8.GetBytes(plainText);
            var passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            var bytesEncrypted = Encrypt(bytesToBeEncrypted, passwordBytes);

            return Convert.ToBase64String(bytesEncrypted);
        }

        public static string Decrypt(string encryptedText, string password = "secureSHa256")
        {
            if (encryptedText == null) return null;

            if (password == null) password = string.Empty;

            // Get the bytes of the string
            var bytesToBeDecrypted = Convert.FromBase64String(encryptedText);
            var passwordBytes = Encoding.UTF8.GetBytes(password);

            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            var bytesDecrypted = Decrypt(bytesToBeDecrypted, passwordBytes);

            return Encoding.UTF8.GetString(bytesDecrypted);
        }

        private static byte[] Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            var saltBytes = new byte[] { 76, 88, 57, 07, 42, 244, 13, 48, 88 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }

                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        private static byte[] Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            var saltBytes = new byte[] {76, 88, 57, 07, 42, 244, 13, 48, 88};

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }

                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
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
    }