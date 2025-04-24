using LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record Title
    {
        public string Value { get; set; }
        public Title(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new TitleNullOrEmptyException();
            }
            if (value.Length > 50)
            {
                throw new InvalidTitleLengthException();
            }
            Value= value;
        }
        public static implicit operator string(Title title)=> title.Value;
        public static implicit operator Title(string title)=> new(title);
    }
}
