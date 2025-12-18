using System;

class Program
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool valid = DateTime.TryParse($"{y}-{m}-{d}", out _);
        Console.WriteLine(valid ? "Корректна" : "Некорректна");
    }
}
