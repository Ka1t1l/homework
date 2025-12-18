using System;

class Program
{
    static void Main()
    {
        int[] times = { 12, 11, 13, 10, 14, 9 };

        Array.Sort(times);

        Console.WriteLine("Лучшие 4 результата:");
        for (int i = 0; i < 4; i++)
            Console.WriteLine(times[i]);
    }
}
