using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TimeCounter
{
    static void Main(string[] args)
    {
        int age, hour, day, week, month;
        long minute, sec;

        Console.Write("Write Your Age: ");

        age = Convert.ToInt32(Console.ReadLine());
        sec = age * 31557600;
        minute = age * 525960;
        hour = age * 8766;
        day = age * 365;
        week = age * 52;
        month = age * 12;

        Console.WriteLine("------------");

        Console.WriteLine("Your Age Is: " + age);

        Console.WriteLine("------------");

        Console.WriteLine("You Lived: " + sec + " Seconds");

        Console.WriteLine("You Lived: " + minute + " Minutes");

        Console.WriteLine("You Lived: " + hour + " Hours");

        Console.WriteLine("You Lived: " + day + " Days");

        Console.WriteLine("You Lived: " + week + " Weeks");

        Console.WriteLine("You Lived: " + month + " Months");

        Console.WriteLine("------------");

        Console.ReadLine();

    }
}
