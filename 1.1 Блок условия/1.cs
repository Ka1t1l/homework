using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int count = 0;
        if (a % 2 == 0) count++;
        if (b % 2 == 0) count++;
        if (c % 2 == 0) count++;

        Console.WriteLine(count == 1 ? "истина" : "ложь");
    }
}
