using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CarRentalApp.Core.domain
{
   public static class ImageUtils
    {
        public static byte[]  ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
    public class  Car
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] CarImage { get; set; }
        public string LicensePlate { get; set; }

        public DateTime? PurchaseDate { get; set; }
        public DateTime? NextDrainDate { get; set; }
        public string Description { get; set; }

        public virtual Classification Classification { get; set; }
        [Range(0, 99999999)]
        public decimal PricePerDay { get; set; }

        public virtual ObservableCollection<Rent> Rents { get; set; } = new ObservableCollection<Rent>();
    }
}
