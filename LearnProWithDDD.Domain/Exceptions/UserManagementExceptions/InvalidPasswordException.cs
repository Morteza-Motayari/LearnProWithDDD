using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidPasswordException:CourseManagementException
    {
        public InvalidPasswordException():base("Password charachters should be just from english alphabet and numbers")
        {
            
        }
    }
}
