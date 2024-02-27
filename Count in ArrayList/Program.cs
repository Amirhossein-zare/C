using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_in_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();

            Console.Write("Enter Your Number 1: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            while (0 <= num)
            {
                if (num > 0)
                {
                    count++;
                    list1.Add(num);
                    Console.Write("Enter Your Number {0}: ", count);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(list1.Count);
                }
                list1.Sort();
                list1.Reverse();
            }
            foreach (var item in list1)
            {
                Console.Write("{0}\t",item);
            }





            Console.ReadKey();

        }
    }
}
