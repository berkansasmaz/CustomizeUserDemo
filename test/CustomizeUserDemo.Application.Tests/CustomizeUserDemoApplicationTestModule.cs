using Volo.Abp.Modularity;

namespace CustomizeUserDemo
{
    [DependsOn(
        typeof(CustomizeUserDemoApplicationModule),
        typeof(CustomizeUserDemoDomainTestModule)
        )]
    public class CustomizeUserDemoApplicationTestModule : AbpModule
    {

    }
}