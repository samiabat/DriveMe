using DriveMe.Application.Contracts.Persistence;
using DriveMe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Persistence.Repositories
{
    public class RideRequestRepository: GenericRepository<RideRequest>, IRideRequestRepository
    {
        public RideRequestRepository(DriveMeDBContext driveMeDBContext): base(driveMeDBContext)
        {
            
        }
    }
}
