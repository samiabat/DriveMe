namespace DriveMe.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository CarRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IRideRequestRepository RideRequestRepository { get; }
        IUserRepository UserRepository { get; }
        Task<int> Save();
    }
}
