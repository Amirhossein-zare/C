using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Tamrini_Simple
{
    internal class Time
    {
        public string Date()
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            
            int Day = persianCalendar.GetDayOfMonth(DateTime.Now);
            int Mounth = persianCalendar.GetMonth(DateTime.Now);
            int Year = persianCalendar.GetYear(DateTime.Now);

            string date = Day + "/" + Mounth + "/" + Year;
            date.Reverse();
            return date;
        }
        public string time()
        {
            PersianCalendar persianTime = new PersianCalendar();

            int sec = persianTime.GetSecond(DateTime.Now);
            int min = persianTime.GetMinute(DateTime.Now);
            int hour = persianTime.GetHour(DateTime.Now);

            string time = sec + "/" + min + "/" + hour;
            time.Reverse();

            return time;
        }
    }
}
