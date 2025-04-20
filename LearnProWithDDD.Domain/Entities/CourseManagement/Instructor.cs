using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Entities.CourseManagement
{
    public class Instructor
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public string Bio { get; set; }
        public List<Course> Courses { get; set; }
    }
}
