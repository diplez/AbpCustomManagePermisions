using diplez.test1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace diplez.test1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(test1EntityFrameworkCoreModule),
    typeof(test1ApplicationContractsModule)
    )]
public class test1DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
