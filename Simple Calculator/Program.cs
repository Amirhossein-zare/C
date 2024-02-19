using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First Num:");
            float num1 = float.Parse((Console.ReadLine()));

            Console.Clear();

            Console.Write("Enter Your Second Num:");
            float num2 = float.Parse(Console.ReadLine());

            Console.Clear();

            float temp;
            if (num1 < num2) 
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine("Enter Your Operation: \n 1.+ \t 2. -\t 3. / \t 4. * \t 5. % \t");
            var opr = Convert.ToInt32(Console.ReadLine());

            switch(opr)
            {
                case 1: 
                    Console.Write("Your Sum is: {0}+{1}={2}", num1 , num2, num1 + num2);
                    break;
                case 2:
                    Console.Write("Your Minus is: {0}-{1}={2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.Write("Your Divide is: {0}/{1}={2}", num1, num2, num1 / num2);
                    break;
                case 4:
                    Console.Write("Your Multipy is: {0}*{1}={2}", num1, num2, num1 * num2);
                    break;
                case 5:
                    Console.Write("Your Rest is: {0}%{1}={2}", num1, num2, num1 % num2);
                    break;
                default:
                    Console.Write("Plz Enter A Valid Opr Number");
                    break;
            }
            Console.WriteLine();
        }
    }
}
