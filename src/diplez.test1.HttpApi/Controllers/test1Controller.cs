using diplez.test1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace diplez.test1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class test1Controller : AbpControllerBase
{
    protected test1Controller()
    {
        LocalizationResource = typeof(test1Resource);
    }
}
