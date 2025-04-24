using LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record Price
    {
        public string Value { get; set; }
        public Price(string value)
        {
           
            if (value.Length < 0)
            {
                throw new InvalidPriceException();
            }
            Value= value;
        }
        public static implicit operator string(Price price)=> price.Value;
        public static implicit operator Price(string price)=> new(price);
    }
}
