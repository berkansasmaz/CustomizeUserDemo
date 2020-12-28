using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CustomizeUserDemo.Data;
using Volo.Abp.DependencyInjection;

namespace CustomizeUserDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreCustomizeUserDemoDbSchemaMigrator
        : ICustomizeUserDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCustomizeUserDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CustomizeUserDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CustomizeUserDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}