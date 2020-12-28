using CustomizeUserDemo.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace CustomizeUserDemo.EntityFrameworkCore
{
    public static class CustomizeUserDemoEfCoreEntityExtensionMappings
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            CustomizeUserDemoGlobalFeatureConfigurator.Configure();
            CustomizeUserDemoModuleExtensionConfigurator.Configure();

            OneTimeRunner.Run(() =>
            {
                ObjectExtensionManager.Instance
                .MapEfCoreProperty<IdentityUser, string>(
                    nameof(AppUser.Title),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.IsRequired();
                        propertyBuilder.HasMaxLength(UserConsts.MaxTitleLength);
                    }
                ).MapEfCoreProperty<IdentityUser, int>(
                    nameof(AppUser.Reputation),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue(UserConsts.MinReputationValue);
                    }
                );
            });
        }
    }
}
