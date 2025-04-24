using LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions;
using LearnProWithDDD.Domain.Exceptions.PaymentManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record Amount
    {
        public string Value { get; set; }
        public Amount(string value)
        {
           
            if (value.Length < 0)
            {
                throw new InvalidAmountException();
            }
            Value= value;
        }
        public static implicit operator string(Amount amount)=> amount.Value;
        public static implicit operator Amount(string amount)=> new(amount);
    }
}
