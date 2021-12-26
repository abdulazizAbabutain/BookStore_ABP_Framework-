using System.Threading.Tasks;

namespace BookStoreLap.Data
{
    public interface IBookStoreLapDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
