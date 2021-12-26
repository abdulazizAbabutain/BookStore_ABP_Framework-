using System;
using System.Collections.Generic;
using System.Text;
using BookStoreLap.Localization;
using Volo.Abp.Application.Services;

namespace BookStoreLap
{
    /* Inherit your application services from this class.
     */
    public abstract class BookStoreLapAppService : ApplicationService
    {
        protected BookStoreLapAppService()
        {
            LocalizationResource = typeof(BookStoreLapResource);
        }
    }
}
