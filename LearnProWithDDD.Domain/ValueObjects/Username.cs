using LearnProWithDDD.Domain.Exceptions.UserManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record Username
    {
        public string Value { get; set; }
        public Username(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new UsernameNullOrEmptyException();
            }
            if (value.Length > 50)
            {
                throw new InvalidUsernameLengthException();
            }
            Value= value;
        }
        public static implicit operator string(Username username)=> username.Value;
        public static implicit operator Username(string username)=> new(username);
    }
}
