﻿using Volo.Abp.Modularity;

namespace diplez.test1;

[DependsOn(
    typeof(test1ApplicationModule),
    typeof(test1DomainTestModule)
    )]
public class test1ApplicationTestModule : AbpModule
{

}
