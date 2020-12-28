using CustomizeUserDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CustomizeUserDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CustomizeUserDemoController : AbpController
    {
        protected CustomizeUserDemoController()
        {
            LocalizationResource = typeof(CustomizeUserDemoResource);
        }
    }
}