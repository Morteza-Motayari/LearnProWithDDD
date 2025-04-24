using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidUsernameLengthException:CourseManagementException
    {
        public InvalidUsernameLengthException():base("Username can't be more than 50 charachters")
        {
            
        }
    }
}
