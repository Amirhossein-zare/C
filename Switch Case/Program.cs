using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Character: ");
            char opr = Convert.ToChar(Console.ReadLine());

            switch (opr)
            {
                case '+':
                    Console.Write("Sum");
                    break;
                case '-':
                    Console.Write("Minus");
                    break;
                case '*':
                    Console.Write("Multiply");
                    break;
                case '/':
                    Console.Write("Divide");
                    break;
            }
            Console.WriteLine();
        }
    }
}
