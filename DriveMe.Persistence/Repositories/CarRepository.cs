using DriveMe.Application.Contracts.Persistence;
using DriveMe.Domain;

namespace DriveMe.Persistence.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(DriveMeDBContext driveMeDBContext) : base(driveMeDBContext)
        {
        }
    }
}
