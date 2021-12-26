using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BookStoreLap.Data
{
    /* This is used if database provider does't define
     * IBookStoreLapDbSchemaMigrator implementation.
     */
    public class NullBookStoreLapDbSchemaMigrator : IBookStoreLapDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}