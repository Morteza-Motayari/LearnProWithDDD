using LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record FullName
    {
        public string Value { get; set; }
        public FullName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new FullNameNullOrEmptyException();
            }
            if (value.Length > 30)
            {
                throw new InvalidFullNameLengthException();
            }
            Value= value;
        }
        public static implicit operator string(FullName fullname)=> fullname.Value;
        public static implicit operator FullName(string fullname)=> new(fullname);
    }
}
