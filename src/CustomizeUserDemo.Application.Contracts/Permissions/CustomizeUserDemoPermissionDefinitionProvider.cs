using CustomizeUserDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CustomizeUserDemo.Permissions
{
    public class CustomizeUserDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CustomizeUserDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CustomizeUserDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CustomizeUserDemoResource>(name);
        }
    }
}
