using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 3, 5, 7, 9 };

        bool increasing = true;
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] <= a[i - 1])
            {
                increasing = false;
                break;
            }
        }

        Console.WriteLine(increasing
            ? "Массив является возрастающей последовательностью"
            : "Массив НЕ является возрастающей последовательностью");
    }
}
