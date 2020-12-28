using Volo.Abp.Settings;

namespace CustomizeUserDemo.Settings
{
    public class CustomizeUserDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CustomizeUserDemoSettings.MySetting1));
        }
    }
}
