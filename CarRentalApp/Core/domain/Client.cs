using System.Collections.ObjectModel;

namespace CarRentalApp.Core.domain
{
    public class  Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cin { get; set; }
        public string Email  { get; set; }
        public string Phone  { get; set; }
        public string Address  { get; set; }

        public virtual ObservableCollection<Rent> Rents { get; set; } = new ObservableCollection<Rent>();
    }
}
