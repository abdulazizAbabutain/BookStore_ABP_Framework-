using BookStoreLap.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BookStoreLap
{
    [DependsOn(
        typeof(BookStoreLapEntityFrameworkCoreTestModule)
        )]
    public class BookStoreLapDomainTestModule : AbpModule
    {

    }
}