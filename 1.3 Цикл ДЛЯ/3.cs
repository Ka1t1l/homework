using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Числа Армстронга:");

        for (int i = a; i <= b; i++)
        {
            int temp = i, sum = 0;
            while (temp > 0)
            {
                int d = temp % 10;
                sum += d * d * d;
                temp /= 10;
            }

            if (sum == i)
                Console.WriteLine(i);
        }
    }
}
