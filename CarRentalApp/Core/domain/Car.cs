
using System.Collections.Generic;

namespace CarRentalApp.Core.domain
{
    public class  Car
    {
        
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public float PricePerDay { get; set; }

        public virtual ICollection<Rent> Rents { get; set; } = new HashSet<Rent>();
    }
}
