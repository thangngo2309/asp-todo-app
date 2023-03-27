using Volo.Abp.Modularity;

namespace API.ToDo;

[DependsOn(
    typeof(ToDoApplicationModule),
    typeof(ToDoDomainTestModule)
    )]
public class ToDoApplicationTestModule : AbpModule
{

}
