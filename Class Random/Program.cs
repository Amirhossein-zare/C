using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Class_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 20; i++) 
            {
                for (int j = 1; j <= rnd.Next(1,100); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Thread.Sleep(50);
            }
            
        }
    }
}
