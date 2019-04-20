
using System;

namespace CarRentalApp.Core.domain
{
    public enum RentState{ Pending, Validated }

    public class  Rent
    {
        public string RentId { get; set; }
        public int CarId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public RentState State { get; set; }
    }
}
