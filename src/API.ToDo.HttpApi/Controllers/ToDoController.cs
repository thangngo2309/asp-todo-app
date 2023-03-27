using API.ToDo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace API.ToDo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ToDoController : AbpControllerBase
{
    protected ToDoController()
    {
        LocalizationResource = typeof(ToDoResource);
    }
}
