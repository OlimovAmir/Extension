using Extension;
using System;
using System.Collections.Generic;
using Extension_student;

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

        Extension_student.Student student = new Extension_student.Student() { lastName = "Amir", firsName= "Olimov" };

        string fullName = student.GetFullName();
        Console.WriteLine(fullName);

    }
}