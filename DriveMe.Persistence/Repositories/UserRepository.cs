using DriveMe.Application.Contracts.Persistence;
using DriveMe.Domain;
using DriveMe.Persistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Persistence.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(DriveMeDBContext driveMeDBContext): base(driveMeDBContext)
        {
            
        }
    }
}
