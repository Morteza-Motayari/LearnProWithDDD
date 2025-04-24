using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidEmailAddressException : CourseManagementException
    {
        public InvalidEmailAddressException():base("Email Address is Invalid .")
        {
            
        }
    }
}
