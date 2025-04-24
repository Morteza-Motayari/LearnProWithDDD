using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidDescriptionLengthException:CourseManagementException
    {
        public InvalidDescriptionLengthException(int validLength):base($"Description can't be more than {validLength} charachters")
        {
            
        }
    }
}
