using CarRentalApp.Core.domain;
using CarRentalApp.Core.Repositories;

namespace CarRentalApp.Persistence.Repositories
{
    public class CarRepository: Repository<Car, int>, ICarRepository
    {
        public CarRepository(CarRentalAppContext context) : base(context)
        {
        }

        public CarRentalAppContext CarRentalAppContext => Context as CarRentalAppContext;

        public Car GetByResume(string resume)
        {
            return SingleOrDefault(c => c.Resume == resume);
        }

    }
}