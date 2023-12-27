using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    static class MyExtension
    {
        public static void Print(this DateTime dateTime) 
        {
            Console.WriteLine(dateTime);
        }

        public static bool isDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek) 
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }
}
