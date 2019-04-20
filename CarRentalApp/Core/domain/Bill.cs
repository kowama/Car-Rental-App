

namespace CarRentalApp.Core.domain
{
    public class  Bill
    {
        public int Id { get; set; }

        public virtual Rent Rent { get; set; }

        public float Amount  { get; set; }

        public string Details { get; set; }

    }
}
