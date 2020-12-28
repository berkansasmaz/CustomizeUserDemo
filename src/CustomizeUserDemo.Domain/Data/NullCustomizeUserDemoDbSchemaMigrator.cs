using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CustomizeUserDemo.Data
{
    /* This is used if database provider does't define
     * ICustomizeUserDemoDbSchemaMigrator implementation.
     */
    public class NullCustomizeUserDemoDbSchemaMigrator : ICustomizeUserDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}