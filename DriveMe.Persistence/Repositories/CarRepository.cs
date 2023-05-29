using DriveMe.Application.Contracts.Persistence;
using DriveMe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Persistence.Repositories
{
    public class CarRepository: GenericRepository<Car>, ICarRepository
    {
        public CarRepository(DriveMeDBContext driveMeDBContext): base(driveMeDBContext)
        {
            
        }
    }
}
