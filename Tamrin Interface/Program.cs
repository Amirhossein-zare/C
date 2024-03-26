using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IString person = new Inheir();
            Console.WriteLine(person.Print());

            INumber person2 = new Inheir();
            Console.WriteLine(person2.Print()) ;

            ITime person3 = new Inheir();
            Console.WriteLine(person3.Print()) ;
        }
    }
}
