using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class FullNameNullOrEmptyException:CourseManagementException
    {
        public FullNameNullOrEmptyException():base("FullName can't be Null or empty")
        {
            
        }
    }
}
