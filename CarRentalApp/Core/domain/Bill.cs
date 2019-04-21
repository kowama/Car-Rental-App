using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Core.domain
{
    public class  Bill
    {
        public string BillNumber { get; set; }

        public virtual Rent Rent { get; set; }

        [Range(0, 99999999)]
        public float Amount  { get; set; }

        public string Details { get; set; }

    }
}
