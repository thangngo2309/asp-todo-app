using System.Threading.Tasks;

namespace API.ToDo.Data;

public interface IToDoDbSchemaMigrator
{
    Task MigrateAsync();
}
