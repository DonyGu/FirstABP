using Microsoft.EntityFrameworkCore;
using FirstABP.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;

namespace FirstABP.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class FirstABPDbContext : AbpDbContext<FirstABPDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        public FirstABPDbContext(DbContextOptions<FirstABPDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureFullAudited();
                b.ConfigureExtraProperties();
                b.ConfigureConcurrencyStamp();
                b.ConfigureAbpUser();

                //Moved customization to a method so we can share it with the FirstABPMigrationsDbContext class
                b.ConfigureCustomUserProperties();
            });

            /* Configure your own tables/entities inside the ConfigureFirstABP method */

            builder.ConfigureFirstABP();
        }
    }
}
