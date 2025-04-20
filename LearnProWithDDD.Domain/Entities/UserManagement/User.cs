using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Entities.UserManagement
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Passwordhash { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
