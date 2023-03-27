using API.ToDo.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace API.ToDo.IToDoItemServices
{
    public interface IToDoItemsService : IApplicationService
    {
        Task<List<ToDoItemsModel>> GetToDoItems(Guid? id);
        Task<ToDoItemsModel> InsertToDoItem(ToDoItemsModel param);
        Task<ToDoItemsModel> UpdateToDoItem(ToDoItemsModel param);
        Task<bool> DeleteToDoItem(Guid id);
    }
}
