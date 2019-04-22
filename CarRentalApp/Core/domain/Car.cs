using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Core.domain
{
    public class  Car
    {
        
        public int Id { get; set; }

        public string LicensePlate { get; set; }

        public string Description { get; set; }

        public virtual Classification Classification { get; set; }

        [Range(0, 99999999)]
        public decimal PricePerDay { get; set; }
        

        public virtual ObservableCollection<Rent> Rents { get; set; } = new ObservableCollection<Rent>();
    }
}
