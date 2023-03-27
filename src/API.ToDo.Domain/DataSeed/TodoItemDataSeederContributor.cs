using API.ToDo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ABP.ToDo.DataSeed
{
    public class TodoItemDataSeederContributor
    : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<ToDoItem, Guid> _todoRepository;

        public TodoItemDataSeederContributor(IRepository<ToDoItem, Guid> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _todoRepository.GetCountAsync() <= 0)
            {
                await _todoRepository.InsertAsync(
                    new ToDoItem
                    {
                        Title ="Test To Do App",
                        Description ="Check ABC 4 67 ",
                        DueDate= new DateTime(2023, 3, 26),
                        DayContrain = 4,
                        IsDeleted = false
                       
                    },
                    autoSave: true
                );

                await _todoRepository.InsertAsync(
                     new ToDoItem
                     {
                         Title = "Test To Do App 2 ",
                         Description = "Check ABC 4 67 ",
                         DueDate = new DateTime(2023, 3, 26),
                         DayContrain = 4,
                         IsDeleted = false

                     },
                     autoSave: true
                 );
            }
        }
    }
}
