using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace CustomizeUserDemo.EntityFrameworkCore
{
    public static class CustomizeUserDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureCustomizeUserDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CustomizeUserDemoConsts.DbTablePrefix + "YourEntities", CustomizeUserDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}