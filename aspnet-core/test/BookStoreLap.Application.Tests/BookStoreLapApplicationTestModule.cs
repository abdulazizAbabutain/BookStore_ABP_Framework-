using Volo.Abp.Modularity;

namespace BookStoreLap
{
    [DependsOn(
        typeof(BookStoreLapApplicationModule),
        typeof(BookStoreLapDomainTestModule)
        )]
    public class BookStoreLapApplicationTestModule : AbpModule
    {

    }
}