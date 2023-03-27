using System;
using System.Collections.Generic;
using System.Text;
using API.ToDo.Localization;
using Volo.Abp.Application.Services;

namespace API.ToDo;

/* Inherit your application services from this class.
 */
public abstract class ToDoAppService : ApplicationService
{
    protected ToDoAppService()
    {
        LocalizationResource = typeof(ToDoResource);
    }
}
