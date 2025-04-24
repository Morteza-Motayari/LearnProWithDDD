using LearnProWithDDD.Domain.Exceptions.UserManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record Email
    {
        public string Value { get; set; }
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmailNullOrEmptyException();
            }

            var emailAddress=new System.Net.Mail.MailAddress(value);
            if(emailAddress.Address!=null)
            {
                throw new InvalidEmailAddressException();
            }
            Value= value;
        }
        public static implicit operator string(Email email)=> email.Value;
        public static implicit operator Email(string email)=> new(email);
    }
}
