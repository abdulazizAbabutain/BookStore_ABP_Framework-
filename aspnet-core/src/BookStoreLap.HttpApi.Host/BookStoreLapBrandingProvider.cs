using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookStoreLap
{
    [Dependency(ReplaceServices = true)]
    public class BookStoreLapBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BookStoreLap";
    }
}
