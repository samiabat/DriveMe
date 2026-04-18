using DriveMe.Domain;

namespace DriveMe.Application.Contracts.Persistence
{
    public interface ICarRepository : IGenericRepository<Car>
    {
        ICarRepository CarRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IRideRequestRepository RideRequestRepository { get; }
        IUserRepository UserRepository { get; }
        Task<int> Save();
    }
}
