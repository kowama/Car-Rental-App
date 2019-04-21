using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Core.domain
{
    public class  Car
    {
        
        public int Id { get; set; }

        public string LicensePlate { get; set; }

        public string Description { get; set; }

        [Range(0, 99999999)]
        public float PricePerDay { get; set; }

        public virtual ICollection<Rent> Rents { get; set; } = new HashSet<Rent>();
    }
}
