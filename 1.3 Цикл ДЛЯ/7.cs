using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 2)
        {
            Console.WriteLine(1);
            return;
        }

        long f1 = 1, f2 = 1;

        for (int i = 3; i <= n; i++)
        {
            long f = f1 + f2;
            f1 = f2;
            f2 = f;
        }

        Console.WriteLine($"F({n}) = {f2}");
    }
}
