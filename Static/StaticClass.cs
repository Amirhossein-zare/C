using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Static
{
    internal class StaticClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public static int Count { get; set; } = 0;

        public StaticClass()
        {
            Count++;
        }

        public void Info()
        {
            Console.WriteLine("id: {0}\tname: {1}\tlname: {2}||Count is: {3}",Id, Name,Lname,Count);
        }
        public static void PName()
        {
            Console.WriteLine("web site users: {0}",Count);
        }
    }
}
