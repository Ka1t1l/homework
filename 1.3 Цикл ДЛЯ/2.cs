using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        long result = 1;
        for (int i = n; i > 0; i -= 2)
            result *= i;

        Console.WriteLine("n!! = " + result);
    }
}
