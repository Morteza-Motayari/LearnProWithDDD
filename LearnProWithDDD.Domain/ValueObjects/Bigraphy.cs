using LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record Bigraphy
    {
        public string Value { get; set; }
        public Bigraphy(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new BigraphyNullOrEmptyException();
            }
            if (value.Length > 300)
            {
                throw new InvalidBiographyLengthException();
            }
            Value= value;
        }
        public static implicit operator string(Bigraphy bigraphy)=> bigraphy.Value;
        public static implicit operator Bigraphy(string bigraphy)=> new(bigraphy);
    }
}
