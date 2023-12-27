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
    }
}
