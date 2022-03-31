using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class DateService
    {
        public static DayOfWeek GetDay(DateTime date)
        {
            return date.DayOfWeek;
        }    
        public static int GetDaysSpan(int day, int month, int year)
        {
        DateTime date = new DateTime(year, month, day);
        DateTime currentDay = DateTime.UtcNow;
        TimeSpan tmp = date - currentDay;
        return tmp.Days;
        }
    }
}
