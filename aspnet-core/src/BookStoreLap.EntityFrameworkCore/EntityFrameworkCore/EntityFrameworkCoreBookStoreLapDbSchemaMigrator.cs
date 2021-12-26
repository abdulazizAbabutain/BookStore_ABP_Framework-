using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStoreLap.Data;
using Volo.Abp.DependencyInjection;

namespace BookStoreLap.EntityFrameworkCore
{
    public class EntityFrameworkCoreBookStoreLapDbSchemaMigrator
        : IBookStoreLapDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBookStoreLapDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BookStoreLapDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BookStoreLapDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
