
using API.ToDo.IToDoItemServices;
using API.ToDo.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ToDo.Controllers
{
   
    [Route("td")]
    [AllowAnonymous]
    public class ToDoItemController : ToDoController
    {
        private readonly IToDoItemsService _todoitemsService;

        public ToDoItemController(IToDoItemsService todoitemsService)
        {
            _todoitemsService = todoitemsService;
        }
        [HttpGet("GetToDoItems")]
        public async Task<List<ToDoItemsModel>> GetToDoItems(Guid? id)
        {
            return await _todoitemsService.GetToDoItems(id);
        }
        [HttpPost("InsertToDoItem")]
        public async Task<ToDoItemsModel> InserToDoItem([FromBody] ToDoItemsModel param)
        {
            return await _todoitemsService.InsertToDoItem(param);
        }
        [HttpPut("UpdateToDoItem")]
        public async Task<ToDoItemsModel> UpdateToDoItem([FromBody] ToDoItemsModel param)
        {
            return await _todoitemsService.UpdateToDoItem(param);
        }
        [HttpDelete("DeleteToDoItem")]
        public async Task<bool> DeleteToDoItems(Guid id)
        {
            return await _todoitemsService.DeleteToDoItem(id);
        }
    }
}
