using System.Collections.ObjectModel;

namespace CarRentalApp.Core.domain
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

    }
}