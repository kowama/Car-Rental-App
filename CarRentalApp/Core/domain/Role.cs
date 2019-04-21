using System.Collections.Generic;

namespace CarRentalApp.Core.domain
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

    }
}