using System;
using System.Collections.Generic;
using System.Text;
using diplez.test1.Localization;
using Volo.Abp.Application.Services;

namespace diplez.test1;

/* Inherit your application services from this class.
 */
public abstract class test1AppService : ApplicationService
{
    protected test1AppService()
    {
        LocalizationResource = typeof(test1Resource);
    }
}
