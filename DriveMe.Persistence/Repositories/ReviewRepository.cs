using DriveMe.Application.Contracts.Persistence;
using DriveMe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Persistence.Repositories
{
    public class ReviewRepository: GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(DriveMeDBContext driveMeDBContext): base(driveMeDBContext)
        {
            
        }
    }
}
