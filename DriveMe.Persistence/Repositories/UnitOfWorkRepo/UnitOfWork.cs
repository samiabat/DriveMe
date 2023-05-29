using DriveMe.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Persistence.Repositories.UnitOfWorkRepo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DriveMeDBContext _context;
        private IUserRepository _userRepository;

        private ICarRepository _carRepository;
        private IReviewRepository _reviewRepository;
        private IRideRequestRepository _rideRequestRepository;
        public UnitOfWork(DriveMeDBContext context)
        {
            _context = context;
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_context);
                return _userRepository;
            }
        }
        public ICarRepository CarRepository
        {
            get
            {
                if (_carRepository == null)
                    _carRepository = new CarRepository(_context);
                return _carRepository;
            }
        }

        public IReviewRepository ReviewRepository
        {
            get
            {
                if (_reviewRepository == null)
                    _reviewRepository = new ReviewRepository(_context);
                return _reviewRepository;
            }
        }

        public IRideRequestRepository RideRequestRepository
        {
            get
            {
                if (_rideRequestRepository == null)
                    _rideRequestRepository = new RideRequestRepository(_context);
                return _rideRequestRepository;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
