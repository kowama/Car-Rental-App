using System.Collections.ObjectModel;

namespace CarRentalApp.Core.domain
{
    public class  User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Cin { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email  { get; set; }
        public string Phone  { get; set; }

        public virtual ObservableCollection<Rent> Rents { get; set; } = new ObservableCollection<Rent>();
        public virtual ObservableCollection<Role> Roles { get; set; } = new ObservableCollection<Role>();

        public string FullName => $"{FirstName} {LastName}";

        public bool HasRole(string roleName)
        {
            foreach (var role in Roles)
                if (role.Name == roleName)
                    return true;

            return false;
        }
    }
}
