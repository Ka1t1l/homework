using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] b = { 3, 4, 5, 6 };

        int count = 0;

        for (int i = 0; i < a.Length; i++)
            for (int j = 0; j < b.Length; j++)
                if (a[i] == b[j])
                {
                    count++;
                    break;
                }

        Console.WriteLine("Количество: " + count);
    }
}
