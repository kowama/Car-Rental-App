using System.Collections.ObjectModel;

namespace CarRentalApp.Core.domain
{
    public class Classification
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();

    }

}