using BookStoreLap.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookStoreLap.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BookStoreLapController : AbpControllerBase
    {
        protected BookStoreLapController()
        {
            LocalizationResource = typeof(BookStoreLapResource);
        }
    }
}