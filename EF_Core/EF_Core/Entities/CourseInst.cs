using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class CourseInst
    {
        public int InstId { get; set; }

        public int CourseId { get; set; }

        public DateTime Evaluate { get; set; }

    }
}
