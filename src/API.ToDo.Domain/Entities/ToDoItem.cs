using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace API.ToDo.Entities
{
    public class ToDoItem : AuditedAggregateRoot<Guid>
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public double DayContrain { get; set; }
        public bool IsDeleted { get; set; }

    }
}
