using API.ToDo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace API.ToDo;

[DependsOn(
    typeof(ToDoEntityFrameworkCoreTestModule)
    )]
public class ToDoDomainTestModule : AbpModule
{

}
