using DriveMe.Application.Contracts.Persistence;
using DriveMe.Domain;

namespace DriveMe.Persistence.Repositories
{
    public class RideRequestRepository : GenericRepository<RideRequest>, IRideRequestRepository
    {
        public RideRequestRepository(DriveMeDBContext driveMeDBContext) : base(driveMeDBContext)
        {
        }
    }
}
