using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FirstABP.EntityFrameworkCore
{
    public class FirstABPMigrationsDbContextFactory : IDesignTimeDbContextFactory<FirstABPMigrationsDbContext>
    {
        public FirstABPMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<FirstABPMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new FirstABPMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
