using DriveMe.Application.Contracts.Persistence;
using DriveMe.Persistence.Repositories;
using DriveMe.Persistence.Repositories.UnitOfWorkRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DriveMeDBContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("DriveMeConnectionString")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IRideRequestRepository, RideRequestRepository>();
            return services;
        }
    }
}
