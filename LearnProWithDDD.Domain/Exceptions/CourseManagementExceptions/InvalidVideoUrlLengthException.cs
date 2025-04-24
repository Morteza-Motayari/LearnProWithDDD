using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidVideoUrlLengthException:CourseManagementException
    {
        public InvalidVideoUrlLengthException():base("VideoUrl can't be more than 100 charachters")
        {
            
        }
    }
}
