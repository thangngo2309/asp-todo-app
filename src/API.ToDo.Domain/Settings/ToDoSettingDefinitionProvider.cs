using Volo.Abp.Settings;

namespace API.ToDo.Settings;

public class ToDoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ToDoSettings.MySetting1));
    }
}
