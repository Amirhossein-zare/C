using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrini_Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            for (int i = 0;i <= 1;i++)
            {
                Console.Write("Enter Your Id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Your Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Your Lname: ");
                string lname = Console.ReadLine();

                Console.Write("Enter Your Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Student student = new Student(id,name,lname,age);

                Console.Write("Enter Your CourseNedded: ");
                int need = Convert.ToInt32(Console.ReadLine());


                Console.Clear();

                for (int j = 0;j <= students.Count;j++)
                {

                    Console.Write("Enter CourseCode {0}-{1}: ",i+1 ,j+1);
                    int code = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter CourseName {0}-{1}: ",i + 1,j + 1);
                    string cname = Console.ReadLine();

                    Console.Write("Enter CourseMaster {0}-{1}: ", i + 1, j + 1);
                    string master = Console.ReadLine();

                    Console.Write("Enter CourseUnit {0}-{1}: ", i + 1, j + 1);
                    int unit = Convert.ToInt32(Console.ReadLine());

                    Course course = new Course(code,cname,master,unit);

                    for (int m = 0;m <= students.Count;m++)
                    {
                        Time time = new Time();
                        time.Date();
                        time.time();
                    }

                    student.AddCourse(course);
                    Console.Clear();
                }
                students.Add(student);
                Console.Clear();
                

            }
            foreach (var item in students)
            {
                item.StudentInfo();
                for (int k = 0;k < item.Courses.Count;k++)
                {
                    item.Courses[k].CourseInfo();
                }
            }

        }
    }
}
