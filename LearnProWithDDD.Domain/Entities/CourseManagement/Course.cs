using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Entities.CourseManagement
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public Guid InstructorId { get; set; }
        public Instructor instructor { get; set; }
        public List<CourseAttendee> courseAttendee { get; set; }
        public List<CourseCatalog> courseCatalog { get; set; }
    }
}
