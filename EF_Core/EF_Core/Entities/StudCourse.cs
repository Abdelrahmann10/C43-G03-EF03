using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class StudCourse
    {

        public int studId { get; set; }

        public int CourseId { get; set; }

        public float Grade { get; set; }
    }
}
