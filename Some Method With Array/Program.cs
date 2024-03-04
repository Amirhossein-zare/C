using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Method_With_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "My name Is amir. amir is master.";

            string[] Fname = { "arshi", "amir", "akbar", "sara" };

            string a = string.Join(" ", Fname);
            Console.WriteLine(a);


            bool flag = name.Equals();
            Console.WriteLine(flag);


            string[] a = name.Split(' ');
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(a.Length);



            int a;
            float b;
            bool c;
            decimal d;
            short e;
            true.ToString();
            (3.14f).ToString();
            char 'a'.ToString();
            a.ToString();
            b.ToString();
            c.ToString();
            d.ToString();
            e.ToString();
            ToString();


            int a = name.Substring(1, 5).Replace("m", "*").IndexOf("*");
            Console.WriteLine(a);


            string a = name.Substring(5);
            Console.WriteLine(a);


            string a = name.TrimStart();
            Console.WriteLine(a);


            string a = name.TrimEnd();
            Console.WriteLine(a);


            string a = name.Trim();
            Console.WriteLine(a)


            string a = name.ToUpper();
            Console.WriteLine(a);

            string b = name.ToLower();
            Console.WriteLine(b);


            bool a = name.EndsWith("r");
            Console.WriteLine(a);


            bool a = name.StartsWith("M");
            Console.WriteLine(a);


            bool flag = name.Contains("amir");
            Console.WriteLine(flag);


            name = name.Remove(name.IndexOf("amir"), 3);
            Console.WriteLine(name);


            string a = name.Remove(5, 10);
            Console.WriteLine(a);



            string a = name.Replace("a", "*");
            Console.WriteLine(a);



            int a = name.LastIndexOf("a");
            Console.WriteLine(a);



            int a = name.IndexOf("Is", 9);
            Console.WriteLine(a);


            int a = name.Length;
            Console.WriteLine(a);


            int[] a = new int[10];
            string[] name = new string[10];
            char[] chararray = new char[10];
            bool[] boolarray = new bool[10];
            float[] floatarray = new float[10];

            string firstname = "amir hossein zare";
        }
    }
}
