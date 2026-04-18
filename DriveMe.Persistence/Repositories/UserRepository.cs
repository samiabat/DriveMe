using DriveMe.Application.Contracts.Persistence;
using DriveMe.Domain;

namespace DriveMe.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DriveMeDBContext driveMeDBContext) : base(driveMeDBContext)
        {
        }
    }
}
