
using System;

namespace CarRentalApp.Core.domain
{
    public enum RentState{ Pending, Validated, Canceled }

    public class  Rent
    {

        public Guid RentId { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }

        public virtual  User ManageBy { get; set; }


        public virtual Bill Bill { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public RentState State { get; set; }

        public double NumberOfDays
        {
            get
            {
                if (DateEnd == null)
                {
                    return 0;
                }

                return ((TimeSpan)(DateEnd - DateStart)).TotalDays;

            }
        }

    }
}
