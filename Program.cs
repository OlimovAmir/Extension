using Extension;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;
        dateTime.Print();

        Console.WriteLine(dateTime.isDayOfWeek(DayOfWeek.Wednesday));
        if (dateTime.isDayOfWeek(DayOfWeek.Wednesday))
        {
            Console.WriteLine("Сегодня начнем работать");
        }
    }
}