using LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record Description
    {
        public string Value { get; set; }
        public Description(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new DescriptionNullOrEmptyException();
            }
            if (value.Length > 200)
            {
                throw new InvalidDescriptionLengthException(200);
            }
            Value= value;
        }
        public static implicit operator string(Description description)=> description.Value;
        public static implicit operator Description(string description)=> new(description);
    }
}
