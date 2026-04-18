using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DriveMe.Persistence
{
    public class DriveMeDBContextFactory
    {
        public DriveMeDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var builder = new DbContextOptionsBuilder<DriveMeDBContext>();
            var connectionString = configuration.GetConnectionString("DriveMeConnectionString");

            builder.UseNpgsql(connectionString);

            return new DriveMeDBContext(builder.Options);
        }
    }
}
