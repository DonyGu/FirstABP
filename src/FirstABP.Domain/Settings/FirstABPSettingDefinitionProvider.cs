using Volo.Abp.Settings;

namespace FirstABP.Settings
{
    public class FirstABPSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FirstABPSettings.MySetting1));
        }
    }
}
