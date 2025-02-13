using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime HiringDate { get; set; }



        public List<Student> Students { get; set; }





        [ForeignKey(nameof(Instructor))]
        public int? InstructorId { get; set; }


        public Instructor Manger { get; set; }

        public List<Instructor> Instructors { get;} 




    }
}
