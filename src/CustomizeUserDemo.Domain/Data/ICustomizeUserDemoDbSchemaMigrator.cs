using System.Threading.Tasks;

namespace CustomizeUserDemo.Data
{
    public interface ICustomizeUserDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
