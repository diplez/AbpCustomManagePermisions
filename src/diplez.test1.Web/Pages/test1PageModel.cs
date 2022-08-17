using diplez.test1.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace diplez.test1.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class test1PageModel : AbpPageModel
{
    protected test1PageModel()
    {
        LocalizationResourceType = typeof(test1Resource);
    }
}
