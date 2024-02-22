using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    internal class Person
    {
        private int personId;
        private string personName;
        private string personLastName;
        private int personAge;
        private float personAvg;

        public int PersonId
        {
            set { personId = value; }
            get { return personId; }
        }

        public string PersonName
        {
            set { personName = value; }
            get { return personName; }
        }

        public string PersonLastName
        {
            set { personLastName = value; }
            get { return personLastName; }
        }

        public int PersonAge
        {
            set { personAge = value; }
            get { return personAge; }
        }

        public float PersonAvg
        {
            set { personAvg = value; }
            get { return personAvg; }
        } 

        public void PersonInfo()
        {
            Console.WriteLine("id: {0}\tname: {1}\tLname: {2}\tAge: {3}\tAvg: {4}", personId, personName, personLastName, personAge, personAvg);
        }
        /// <summary>
        /// این متد برای مقدار دهی اعضای خصوصی کلاس استفاده میشود
        /// </summary>
        /// <param name="personId">شماره</param>
        /// <param name="personName">نام</param>
        /// <param name="personLastName">فامیلی</param>
        /// <param name="personAge">سن</param>
        /// <param name="personAvg">میانگین نمرات</param>
        public void Setter(int personId, string personName, string personLastName, int personAge, float personAvg)
        {
            this.personId = personId;
            this.personName = personName;
            this.personLastName = personLastName;
            this.personAge = personAge;
            this.personAvg = personAvg;
        }
        public void Setter(int personId, string personName, string personLastName, int personAge)
        {
            this.personId = personId;
            this.personName = personName;
            this.personLastName = personLastName;
            this.personAge = personAge;
        }
        public void Setter(int personId, string personName, string personLastName)
        {
            this.personId = personId;
            this.personName = personName;
            this.personLastName = personLastName;
        }
        public void Setter(int personId, string personName)
        {
            this.personId = personId;
            this.personName = personName;
        }
        public void Setter(int personId)
        {
            this.personId = personId;
        }
    }
}
