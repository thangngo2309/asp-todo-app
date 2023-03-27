using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp;

using Microsoft.VisualBasic;
using API.ToDo;
using API.ToDo.IToDoItemServices;
using API.ToDo.Entities;
using API.ToDo.Response;

namespace ABP.ToDo.ToDoItemServices
{
    public class ToDoItemsService : ToDoAppService, IToDoItemsService
    {
       
        private readonly IRepository<ToDoItem> _todoitemsRepository;
        public ToDoItemsService(IRepository<ToDoItem> todoitemsRepository)
        {
            _todoitemsRepository = todoitemsRepository;
        }
      
        private bool CheckSQLInjectionInsertHoliday(ToDoItemsModel param)
        {
            if (param.Description.Contains('<') || param.Description.Contains('>'))
                return false;
            return true;
        }

        public async Task<List<ToDoItemsModel>> GetToDoItems(Guid? id)
        {
            var data = await _todoitemsRepository.GetListAsync(x => (id == null || x.Id == id) && x.IsDeleted == false);
            var res = ObjectMapper.Map<List<ToDoItem>, List<ToDoItemsModel>>(data);
            return res.ToList();
        }

        public async Task<ToDoItemsModel> InsertToDoItem(ToDoItemsModel param)
        {
            if (!CheckSQLInjectionInsertHoliday(param))
                throw new UserFriendlyException("SQL Injection detected.");
            ToDoItem data = new ToDoItem()
                {
                    Title = param.Title,
                    Description = param.Description,
                    DueDate = param.DueDate,
                    DayContrain = (param.DueDate - DateTime.Now).TotalDays,
                    IsDeleted = false,
                    CreationTime = DateTime.Now,
                };
            
            await _todoitemsRepository.InsertAsync(data, true);
            ToDoItemsModel result = ObjectMapper.Map<ToDoItem, ToDoItemsModel>(data);
            return result;
        }

        public async Task<ToDoItemsModel> UpdateToDoItem(ToDoItemsModel param)
        {
            if (!CheckSQLInjectionInsertHoliday(param))
                throw new UserFriendlyException("SQL Injection detected.");

            var data = await _todoitemsRepository.FirstOrDefaultAsync(x => x.Id == param.Id);
            if (data == null)
                throw new UserFriendlyException("Không tìm thấy dữ liệu trong hệ thống.");

            data.Description = param.Description;
            data.DueDate = param.DueDate;
            data.DayContrain = (param.DueDate - DateTime.Now).TotalDays;
            await _todoitemsRepository.UpdateAsync(data, true);
            ToDoItemsModel result = ObjectMapper.Map<ToDoItem, ToDoItemsModel>(data);
            return result;
        }
        public async Task<bool> DeleteToDoItem(Guid id)
        {
            var check = await _todoitemsRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (check == null)
                throw new UserFriendlyException("Không tìm thấy dữ liệu trong hệ thống.");
            check.IsDeleted = true;
            await _todoitemsRepository.UpdateAsync(check);
            return true;
        }
    }
}
