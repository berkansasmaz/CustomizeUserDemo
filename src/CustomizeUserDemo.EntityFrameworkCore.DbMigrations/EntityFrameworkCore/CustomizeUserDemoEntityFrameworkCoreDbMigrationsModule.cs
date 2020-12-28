using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CustomizeUserDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(CustomizeUserDemoEntityFrameworkCoreModule)
        )]
    public class CustomizeUserDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CustomizeUserDemoMigrationsDbContext>();
        }
    }
}
