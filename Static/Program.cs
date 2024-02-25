using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Static;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StaticClass st1 = new StaticClass();

            st1.Id = 1;
            st1.Name = "test";
            st1.Lname = "testeeee";
            Console.WriteLine(StaticClass.Count);



            StaticClass st2 = new StaticClass();

            st2.Id = 2;
            st2.Name = "test1";
            st2.Lname = "testeeeeeeee";
            st2.Info();

            


            Console.ReadKey();
        }
    }
}
