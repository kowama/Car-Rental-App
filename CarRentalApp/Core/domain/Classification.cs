using System.Collections.Generic;

namespace CarRentalApp.Core.domain
{
    public class Classification
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();

    }

}