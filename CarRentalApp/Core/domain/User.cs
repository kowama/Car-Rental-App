using System.Collections.Generic;

namespace CarRentalApp.Core.domain
{
    public class  User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email  { get; set; }
        public string Phone  { get; set; }

        public virtual ICollection<Rent> Rents { get; set; } = new HashSet<Rent>();
        public virtual ICollection<Role> Roles { get; set; } = new HashSet<Role>();

    }
}
