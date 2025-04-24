using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidVideoExtensionException : CourseManagementException
    {
        public InvalidVideoExtensionException():base("VideoUrl Extension must be mp4")
        {
            
        }
    }
}
