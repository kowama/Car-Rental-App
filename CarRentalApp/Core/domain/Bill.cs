using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Core.domain
{
    public class  Bill
    {
        public Guid BillNumber { get; set; }

        public DateTime Date { get; set; }

        [Range(0, 99999999)]
        public decimal Amount  { get; set; }

        public string Details { get; set; }

        public virtual Rent Rent { get; set; }

    }
}
