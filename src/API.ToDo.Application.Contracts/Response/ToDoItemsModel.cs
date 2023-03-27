
using API.ToDo.ValidateModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API.ToDo.Response
{
    public class ToDoItemsModel
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "Title is mandatory")]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Date is mandatory")]
        [RestrictedDate(ErrorMessage = "Date is not in the past.")]
        public DateTime DueDate { get; set; }
        public double DayContrain
        {
            get;
            set;  
            
        }
    }
}
