using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Application.Contracts.Persistence
{
    public interface IUnitOfWork: IDisposable
    {
        ICarRepository CarRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IRideRequestRepository RideRequestRepository { get; }
        IUserRepository UserRepository { get; }
        Task<int> Save();
    }
}
