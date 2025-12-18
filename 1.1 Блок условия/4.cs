using System;

class Program
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        int dx = Math.Abs(x1 - x2);
        int dy = Math.Abs(y1 - y2);

        if ((dx == 1 && dy == 2) || (dx == 2 && dy == 1))
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
    }
}
