using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        long sum = 0;

        for (int i = 1; i <= n; i++)
        {
            long product = 1;
            for (int j = i; j <= 2 * i; j++)
                product *= j;

            sum += product;
        }

        Console.WriteLine("Результат: " + sum);
    }
}
