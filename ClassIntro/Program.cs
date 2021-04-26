using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            Course course1 = new Course();
            course1.CourseName = "Python";
            course1.Teacher = "Orçun";
            course1.ViewRate = 88;

            Course course2 = new Course();
            course2.CourseName = "C#";
            course2.Teacher = "Deniz";
            course2.ViewRate = 58;

            Course course3 = new Course();
            course3.CourseName = "C++";
            course3.Teacher = "Görkem";
            course3.ViewRate = 72;




            //Console.WriteLine(course1.CourseName + " : " + course1.Teacher);

            Course[] courses = new Course[] 
            {
                course1,
                course2,
                course3
            
            };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : "+ course.Teacher + " ,View Rate : " + course.ViewRate);
            }





        }
    }

    class Course
    {
        public string  CourseName { get;  set; }
        public string Teacher { get; set; }
        public int ViewRate { get; set; }

    }




}
