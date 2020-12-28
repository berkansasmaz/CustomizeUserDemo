using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CustomizeUserDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class CustomizeUserDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CustomizeUserDemo";
    }
}
