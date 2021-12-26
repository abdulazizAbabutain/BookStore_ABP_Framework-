using Volo.Abp.Settings;

namespace BookStoreLap.Settings
{
    public class BookStoreLapSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BookStoreLapSettings.MySetting1));
        }
    }
}
