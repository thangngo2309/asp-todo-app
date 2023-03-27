using API.ToDo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace API.ToDo.Permissions;

public class ToDoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ToDoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ToDoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ToDoResource>(name);
    }
}
