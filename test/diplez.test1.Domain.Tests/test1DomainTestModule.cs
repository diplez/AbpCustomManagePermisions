using diplez.test1.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace diplez.test1;

[DependsOn(
    typeof(test1EntityFrameworkCoreTestModule)
    )]
public class test1DomainTestModule : AbpModule
{

}
