using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace FirstABP.EntityFrameworkCore
{
    public static class FirstABPDbContextModelCreatingExtensions
    {
        public static void ConfigureFirstABP(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FirstABPConsts.DbTablePrefix + "YourEntities", FirstABPConsts.DbSchema);

            //    //...
            //});
            builder.Entity<Book>(b =>
            {
                b.ToTable(FirstABPConsts.DbTablePrefix + "Books", FirstABPConsts.DbSchema);
                b.ConfigureExtraProperties();
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser : class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}