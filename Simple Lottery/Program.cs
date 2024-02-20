using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random rnd = new Random();

            
            for (int i = 0; i < 20; i++)
            {
                int a = rnd.Next(1, 20);
                Console.WriteLine("Winner: {0}",a);
            }
        }
    }
}
