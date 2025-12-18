using System;

class Program
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(y, m, d).AddDays(1);
        Console.WriteLine($"{date.Day}.{date.Month}.{date.Year}");
    }
}
