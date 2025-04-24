using LearnProWithDDD.Domain.Exceptions.UserManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record Password
    {
        public string Value { get; set; }
        public Password(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new PasswordNullOrEmptyException();
            }
            string pattern = "[^a-zA-Z0-9]";
            var regex=new Regex(pattern);

            if (!regex.IsMatch(value))
            {
                throw new InvalidPasswordException();
            }
            Value = value;
        }
        public static implicit operator string(Password password)=> password.Value;
        public static implicit operator Password(string password)=> new(password);
    }
}
