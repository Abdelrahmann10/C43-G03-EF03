﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Topic
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public List<Course> Courses { get; set; }

    }
}
