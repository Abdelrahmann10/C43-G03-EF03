using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Duration { get; set; }

       

        public List<StudCourse> Students { get; set; }

        public List<CourseInst> Instructors { get; set; }



        public int TopicId { get; set; }
        public Topic Topic { get; set; }

    }
}
