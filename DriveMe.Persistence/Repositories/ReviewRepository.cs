using DriveMe.Application.Contracts.Persistence;
using DriveMe.Domain;

namespace DriveMe.Persistence.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(DriveMeDBContext driveMeDBContext) : base(driveMeDBContext)
        {
        }
    }
}
