using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrence_question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            float avg;
           SumAvg(num1, num2, num3, out sum,out avg);

            Console.WriteLine("Sum is : {0}\t Avg is : {1}",sum,avg);
        }
        static void SumAvg(int a, int b, int c, out int sum, out float avg)
        {
            sum = a + b + c;
            avg = sum / 3.0f;
        }
    }
}
