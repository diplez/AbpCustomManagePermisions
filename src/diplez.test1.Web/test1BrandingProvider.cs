using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace diplez.test1.Web;

[Dependency(ReplaceServices = true)]
public class test1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "test1";
}
