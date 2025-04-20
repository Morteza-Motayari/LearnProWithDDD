using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Entities.UserManagement
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
