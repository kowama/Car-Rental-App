
using System;

namespace CarRentalApp.Core.domain
{
    public enum RentState{ Pending, Validated }

    public class  Rent
    {
        public string RentId { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }

        public virtual  User ManageByUser { get; set; }



        public virtual Bill Bill { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public RentState State { get; set; }
    }
}
