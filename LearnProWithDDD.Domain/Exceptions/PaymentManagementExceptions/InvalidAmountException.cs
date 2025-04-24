using LearnProWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Exceptions.PaymentManagementExceptions
{
    internal class InvalidAmountException : CourseManagementException
    {
        public InvalidAmountException():base("Amount can't be negative")
        {
            
        }
    }
}
