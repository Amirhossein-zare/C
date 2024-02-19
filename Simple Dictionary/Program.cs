using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList dic = new SortedList();
            
            dic.Add("Hello", "Salam");
            dic.Add("Bye", "Khodafez");
            dic.Add("Thank You", "Merci");
            dic.Add("Bag", "Kif");
            dic.Add("Word", "Kalame");
            dic.Add("Food", "Ghaza");
            dic.Add("Boat", "Kashty");
            dic.Add("Sheep", "Gospand");
            dic.Add("Animal", "Heivan");
            dic.Add("Brother", "Baradar");
            dic.Add("Love", "Eshgh");
            dic.Add("Pencil", "Medad");
            dic.Add("Dance", "Raghs");
            dic.Add("Mom", "Mathar");

            Console.Write("Enter Your Word: ");
            string word = Convert.ToString(Console.ReadLine());

            if (dic[word] != null)
            {
                Console.WriteLine(dic[word]);
            }
            else
            {
                Console.Write("Word Not Founded");
            }
            Console.WriteLine();


        }
    }
}
