using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.Entities.CourseManagement
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CourseCatalogId { get; set; }
        public CourseCatalog courseCatalog { get; set; }

    }
}
