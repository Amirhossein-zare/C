using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tamrin_Interface
{
    internal class Inheir : ITime, IString, INumber
    {
        public DateTime Time { get ; set; }
        public string Str { get ; set ; }
        public int Num { get; set; }
        string ITime.Time { get; set ; }

        public string Print()
        {
            PersianCalendar time = new PersianCalendar();
            int day = time.GetDayOfMonth(DateTime.Now);
            int mounth = time.GetMonth(DateTime.Now);
            int year = time.GetYear(DateTime.Now);

            string timeZ = day + "/" + mounth + "/" + year;
            return timeZ;
        }

        string IString.Print()
        {
            string word = "A" + "M" + "I" + "R";
            return word;
        }

        int INumber.Print()
        {
            int sum = 12 + 1;
            return sum / 2;
        }
    }
}
