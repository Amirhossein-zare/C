using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PersonInfo;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            // set
            person1.PersonId = 1;
            // get
            int x = person1.PersonId;
            //set
            person1.PersonName = "Amir";
            person1.PersonLastName = "Zare";
            person1.PersonAge = 21;
            person1.PersonAvg = 14.5f;
            //get
            var a = person1.PersonName;
            var b = person1.PersonLastName;
            var c = person1.PersonAge;
            var d = person1.PersonAvg;
            //Wrtitng methods
            Console.WriteLine(person1.PersonId + " " + person1.PersonName + " " + person1.PersonLastName + " " + person1.PersonAge + " " + person1.PersonAvg + " "); ;

            Console.WriteLine("id: {0}\tname: {1}\tLname: {2}\tAge: {3}\tAvg: {4}"
                , person1.PersonId, person1.PersonName, person1.PersonLastName, person1.PersonAge, person1.PersonAvg);
            Console.WriteLine($"id: {person1.PersonId}\tname: {person1.PersonName}\tlname: {person1.PersonLastName}\t" +
                $"age: {person1.PersonAge}\tavg: {person1.PersonAvg}");
            person1.PersonInfo();

            person1.Setter(1, "amir", "zare", 21, 19.4f);
            

        }
    }
}
