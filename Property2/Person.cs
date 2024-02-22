using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    internal class Person
    {
        int IdPerson;
        string NamePerson;
        string LastName;
        int AgePerson;

        public Person(){}

        public Person(string NamePerson,string LastName)
        {
            this.NamePerson = NamePerson;
            this.LastName = LastName;
        }
        public Person(int IdPerson)
        {
            this.IdPerson = IdPerson;
        }
        public Person(int IdPerson, string NamePerson)
        {
            this.IdPerson = IdPerson;
            this.NamePerson = NamePerson;
        }
        public Person(int IdPerson, string NamePerson, string LastName)
        {
            this.IdPerson = IdPerson;
            this.NamePerson = NamePerson;
            this.LastName = LastName;
        }

        public Person(int IdPerson,string NamePerson,string LastName,int AgePerson)
        {
            this.IdPerson = IdPerson;
            this.NamePerson = NamePerson;
            this.LastName = LastName;
            this.AgePerson = AgePerson;
        }

        public void PersonInfo()
        {
            Console.WriteLine("id: {0}\tname: {1}\tlname: {2}\tage: {3}", IdPerson, NamePerson, LastName, AgePerson); ;
        }
    }
}
