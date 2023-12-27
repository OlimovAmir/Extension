using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension_student;

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

        public static string GetFullName(this Student student) 
        {
            return student.firsName + " " + student.lastName;
        }

    }
}
