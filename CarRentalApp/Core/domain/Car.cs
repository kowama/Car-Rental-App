using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using CarRentalApp.Core.Utils;

namespace CarRentalApp.Core.domain
{
    public class  Car
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] CarImage  { get; set; }
        public string LicensePlate { get; set; }

        public DateTime? PurchaseDate { get; set; }
        public DateTime? NextDrainDate { get; set; }
        public string Description { get; set; }

        public virtual Classification Classification { get; set; }
        [Range(0, 99999999)]
        public decimal PricePerDay { get; set; }

        public virtual ObservableCollection<Rent> Rents { get; set; } = new ObservableCollection<Rent>();

        public string Resume => $"{Name}, {LicensePlate}";

        public bool IsAvailable 
        {
            get
            {
                foreach (var rent in Rents)
                {
                    if (rent.DateEnd <= DateTime.Now)
                        return false;
                }

                return true;
            }
        }


        public static string LicensePlateFromResume(string resume)
        {
            return resume.Split(',').Last().Trim();
        }

        public void SetPicture(Image picture)
        {
            if(picture == null) return;
            CarImage = ImageUtils.ImageToByteArray(picture);
        }

        public Image GetPicture()
        {
            return CarImage == null ? null : ImageUtils.ByteArrayToImage(CarImage);
        }
    }
}
