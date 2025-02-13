using EF_Core.Contexts;
using EF_Core.Entities;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using ItiContext context = new ItiContext();

          

           Student St01 = new Student()
           {
               FName = "Abdelrahman",
               LName = "Sorour",
               Address = "Menofia",
               Age = 25,
               DepartmentId = 10,
           };

            Student St02 = new Student()
            {
                FName = "Ahmed",
                LName = "said",
                Address = "cairo",
                Age = 36,
                DepartmentId = 20,
            };

            Student St03 = new Student()
            {
                FName = "Mohamed",
                LName = "samy",
                Address = "Menofia",
                Age = 63,
                DepartmentId = 30,
            };

            Student St04 = new Student()
            {
                FName = "mohamed",
                LName = "hady",
                Address = "Menofia",
                Age = 58,
                DepartmentId = 40,
            };


            

            context.student.Add(St01);
            context.student.Add(St02); 
            context.student.Add(St02); 
            context.student.Add(St03);


            // =============================================================================
            // =============================================================================
            // =============================================================================
            // =============================================================================




            Department Dept01 = new Department()
            {
                Name = "A",
                HiringDate = DateTime.Now,
                InstructorId = 10,
            };

            Department Dept02 = new Department()
            {
                Name = "B",
                HiringDate = DateTime.Now,
                InstructorId = 11,

            };

            Department Dept03 = new Department()
            {
                Name = "C",
                HiringDate = DateTime.Now,
                InstructorId = 11,

            };

            Department Dept04 = new Department()
            {
                Name = "D",
                HiringDate = DateTime.Now,
                InstructorId = 12,

            };


            context.department.Add(Dept01);
            context.department.Add(Dept02);
            context.department.Add(Dept03);
            context.department.Add(Dept04);




            // =============================================================================
            // =============================================================================
            // =============================================================================
            // =============================================================================







            Topic Top01 = new Topic()
            {
                Name = "BackEnd",

            };

            Topic Top02 = new Topic()
            {
                Name = "FrontEnd"
            };

            Topic Top03 = new Topic()
            {
                Name = "Ux/Ui"
            };

            Topic Top04 = new Topic()
            {
                Name = "Data Analysis"
            };



            context.topic.Add(Top01);
            context.topic.Add(Top02);
            context.topic.Add(Top03);
            context.topic.Add(Top04);



            // =============================================================================
            // =============================================================================
            // =============================================================================
            // =============================================================================






            Course C01 = new Course()
            {
                Name = ".Net",
                Description = "Gamed",
                Duration = DateTime.Now,
                TopicId = 10,
            };


            Course C02 = new Course()
            {
                Name = "Html , Css",
                Description = "Fashee5",
                Duration = DateTime.Now,
                TopicId = 11,
            };

            Course C03 = new Course()
            {
                Name = " Design ",
                Description = "Raye2",
                Duration = DateTime.Now,
                TopicId = 12,
            };


            Course C04 = new Course()
            {
                Name = " Data  ",
                Description = "Raye2",
                Duration = DateTime.Now,
                TopicId = 13,
            };



            context.course.Add(C01);
            context.course.Add(C02);
            context.course.Add(C03);
            context.course.Add(C04);



            // =============================================================================
            // =============================================================================
            // =============================================================================
            // =============================================================================






            Instructor Inst01 = new Instructor()
            {
                Name = "khaled",
                Bouns = 10,
                Salary = 10000,
                Address = "Cairo",
                HourRate = 500,
                DeptId = 14
            };


            Instructor Inst02 = new Instructor()
            {
                Name = "Omar",
                Bouns = 12,
                Salary = 15000,
                Address = "Cairo",
                HourRate = 500,
                DeptId = 13
            };


            Instructor Inst03 = new Instructor()
            {
                Name = "Amr",
                Bouns = 13,
                Salary = 20000,
                Address = "Menofia",
                HourRate = 500,
                DeptId = 12
            };

            Instructor Inst04 = new Instructor()
            {
                Name = "7oda",
                Bouns = 14,
                Salary = 25000,
                Address = "Menofia",
                HourRate = 500,
                DeptId = 11
            };

            context.instructor.Add(Inst01);
            context.instructor.Add(Inst02);
            context.instructor.Add(Inst03);
            context.instructor.Add(Inst04);





            // =============================================================================
            // =============================================================================
            // =============================================================================
            // =============================================================================







            CourseInst CI01 = new CourseInst()
            {
                CourseId = 4,
                InstId = 3,
                Evaluate = DateTime.Now
            };
            CourseInst CI02 = new CourseInst()
            {
                CourseId = 3,
                InstId = 4,
                Evaluate = DateTime.Now
            };
            CourseInst CI03 = new CourseInst()
            {
                CourseId = 2,
                InstId = 1,
                Evaluate = DateTime.Now
            };
            CourseInst CI04 = new CourseInst()
            {
                CourseId = 1,
                InstId = 2,
                Evaluate = DateTime.Now
            };



            context.courseInst.Add(CI01);
            context.courseInst.Add(CI02);
            context.courseInst.Add(CI03);
            context.courseInst.Add(CI04);





            // =============================================================================
            // =============================================================================
            // =============================================================================
            // =============================================================================






            StudCourse SC01 = new StudCourse()
            {
                studId = 4,
                CourseId = 4,
                Grade = 40
            };

            StudCourse SC02 = new StudCourse()
            {
                studId = 3,
                CourseId = 3,
                Grade = 30
            };

            StudCourse SC03 = new StudCourse()
            {
                studId = 2,
                CourseId = 2,
                Grade = 20
            };

            StudCourse SC04 = new StudCourse()
            {
                studId = 1,
                CourseId = 1,
                Grade = 10
            };

            context.studCourse.Add(SC01);   
            context.studCourse.Add(SC02);
            context.studCourse.Add(SC03);
            context.studCourse.Add(SC04);



            // =============================================================================
            // =============================================================================
            // =============================================================================
            // =============================================================================




            var Instructor = context.instructor.Where(I => I.Bouns == 14).FirstOrDefault();

            if (Instructor != null)
            {
                Console.WriteLine(context.Entry(Instructor).State);
                Console.WriteLine(Instructor.Address);
                Instructor.Address = " Menofia ";
                Console.WriteLine(context.Entry(Instructor).State);
                context.SaveChanges();
                Console.WriteLine(context.Entry(Instructor).State);

            }


            var Student = context.student.Where(S => S.Address == "Cairo").FirstOrDefault();

            if (Student!= null)
            {
                Console.WriteLine(context.Entry(Instructor).State);
                Console.WriteLine(Student.Age);
                context.student.Remove(Student);
                Console.WriteLine(context.Entry(Instructor).State);
                context.SaveChanges();
                Console.WriteLine(context.Entry(Instructor).State);

            }


           // context.SaveChanges();

        }
    }
}
