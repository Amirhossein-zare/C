using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Things_With_Founction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name:");
            string a = Console.ReadLine();
            PrintName();
            Console.WriteLine("\nEnter a number: ");
            int b = Convert.ToInt32(Console.ReadLine()); 
            PrintLname(b);

            Console.WriteLine();
        }
    static void PrintName()
    {
        for (int i = 0;i < 10;i++)
        {
            Console.Write("amir {0} ",i);
        }
    }
    static void PrintLname(int count)
        {
            for (int i = 0; i < count;i++)
            {
                Console.Write("zare {0} ",i);
            }
        }
    }
}
