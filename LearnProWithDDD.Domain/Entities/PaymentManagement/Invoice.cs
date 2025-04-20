using LearnProWithDDD.Domain.Entities.CourseManagement;
using LearnProWithDDD.Domain.Entities.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Entities.PaymentManagement
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public User user { get; set; }
        public Guid CourseId { get; set; }
        public Course course { get; set; }

    }
}
