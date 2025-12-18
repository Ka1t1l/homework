using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            int s1 = SumDivisors(i);
            if (s1 > i && s1 <= b && SumDivisors(s1) == i)
                Console.WriteLine($"{i} и {s1}");
        }
    }

    static int SumDivisors(int n)
    {
        int sum = 1;
        for (int i = 2; i <= n / 2; i++)
            if (n % i == 0)
                sum += i;
        return sum;
    }
}
