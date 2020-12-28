using CustomizeUserDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CustomizeUserDemo
{
    [DependsOn(
        typeof(CustomizeUserDemoEntityFrameworkCoreTestModule)
        )]
    public class CustomizeUserDemoDomainTestModule : AbpModule
    {

    }
}