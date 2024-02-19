using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreye_1D_with_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Name = { 'h', 'a', 'n', 'i', 'e', 'h' };

            Console.WriteLine(Name.Length);
            
            Console.WriteLine("************");
            

            foreach (var item in Name)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**********");

            string name = "hanieh";
            Console.WriteLine(name);
            Console.WriteLine();
        }
    }
}
