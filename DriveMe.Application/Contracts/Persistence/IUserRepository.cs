using DriveMe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Application.Contracts.Persistence
{
    public interface IUserRepository: IGenericRepository<User>
    {
    }
}
