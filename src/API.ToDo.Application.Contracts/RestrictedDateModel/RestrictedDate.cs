using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ToDo.ValidateModel
{
    public class RestrictedDate : ValidationAttribute
    {
        public override bool IsValid(object input)
        {
            DateTime date = (DateTime)input;
            return date < DateTime.Now;
        }
    }
}
