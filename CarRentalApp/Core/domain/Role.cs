using System.Collections.ObjectModel;

namespace CarRentalApp.Core.domain
{
    public static class RoleName
    {
        public static readonly string Administrator = "ADMINISTRATOR";
        public static readonly string Manager = "MANAGER";
    }
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

    }
}