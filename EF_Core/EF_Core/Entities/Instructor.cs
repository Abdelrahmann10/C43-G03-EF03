using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }
        public float HourRate { get; set; }
        


        public List<CourseInst> Course { get; set; }






        [InverseProperty(nameof(Department.Manger))]
        public Department Mange { get; set; }




         [ForeignKey(nameof(Contain))]
        public int DeptId { get; set; }


       [InverseProperty(nameof(Department.Instructors))]
        public Department Contain { get; set;}



       


    }
}
