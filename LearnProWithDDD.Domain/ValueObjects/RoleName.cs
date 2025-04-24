using LearnProWithDDD.Domain.Exceptions.UserManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record RoleName
    {
        public string Value { get; set; }
        public RoleName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new RoleNameNullOrEmptyException();
            }
            Value= value;
        }
        public static implicit operator string(RoleName rolename)=> rolename.Value;
        public static implicit operator RoleName(string rolename)=> new(rolename);
    }
}
