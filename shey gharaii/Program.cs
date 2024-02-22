using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Schema;
using System.Web;

namespace shey_gharaii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();



            student1.idInfo(1, "Amir", "Zare", "09142654334", 21);
            student2.idInfo(2, "Arshia", "Zare", "091426532334", 11);
            student3.idInfo(3, "Hanie", "Zare", "09142655424", 21);
            student4.idInfo(4, "Mama", "Zare", "091426512323", 40);

            Console.WriteLine(student1.getid());
            Console.WriteLine(student2.getid());
            Console.WriteLine(student3.getid());
            Console.WriteLine(student4.getid());
            student1.studentInfo();
            student2.studentInfo();
            student3.studentInfo();
            student4.studentInfo();

        }
    }
    class Student
    {
        private string lastName;
        private string firstName;
        private int age;
        private int id;
        private string phoneNumber;

        public void studentInfo()
        {
            Console.WriteLine("name: {0}\tfamily: {1}\tage: {2}\tid: {3}\tphoneNumber: {4}\t",firstName,lastName,age,id,phoneNumber);
        }
        // Setter Method
        /// <summary>
        /// این متد برای پر کردن اطلاعات کاربری است
        /// </summary>
        /// <param name="i">شماره دانشجویی</param>
        /// <param name="f">نام</param>
        /// <param name="l">نام خانوادگی</param>
        /// <param name="p">شماره تماس</param>
        /// <param name="a">سن</param>
        public void idInfo(int i , string f , string l , string p , int a)
        {
            id = i;
            firstName = f;
            lastName = l;
            phoneNumber = p;
            age = a;
        }
        // Getter Method
        public int getid()
        {
            return id;
        }
    }
}
