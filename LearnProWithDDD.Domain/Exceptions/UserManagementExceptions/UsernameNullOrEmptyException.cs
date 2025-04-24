using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class UsernameNullOrEmptyException:CourseManagementException
    {
        public UsernameNullOrEmptyException():base("Username can't be Null or empty")
        {
            
        }
    }
}
