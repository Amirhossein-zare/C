using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tamrini_Simple
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public List<Course> Courses = new List<Course>();
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public List<Time> Times = new List<Time>();
        public void AddTime(Time time)
        {
            Times.Add(time);
        }

        public Student() { }
        public Student (int Id,string Name,string Lname,int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Lname = Lname;
            this.Age = Age;
        }
        public void StudentInfo()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Id: {0}\tName: {1}\tLname: {2}\tAge: {3}",
                Id,Name,Lname,Age);
        }
    }
}
