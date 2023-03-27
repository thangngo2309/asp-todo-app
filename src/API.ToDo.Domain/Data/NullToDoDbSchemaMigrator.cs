using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace API.ToDo.Data;

/* This is used if database provider does't define
 * IToDoDbSchemaMigrator implementation.
 */
public class NullToDoDbSchemaMigrator : IToDoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
