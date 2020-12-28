using CustomizeUserDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CustomizeUserDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CustomizeUserDemoPageModel : AbpPageModel
    {
        protected CustomizeUserDemoPageModel()
        {
            LocalizationResourceType = typeof(CustomizeUserDemoResource);
        }
    }
}