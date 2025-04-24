using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidTitleLengthException:CourseManagementException
    {
        public InvalidTitleLengthException():base("Title can't be more than 50 charachters")
        {
            
        }
    }
}
