using Volo.Abp.Settings;

namespace diplez.test1.Settings;

public class test1SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(test1Settings.MySetting1));
    }
}
