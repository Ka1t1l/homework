using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 2, 3, 4, 4, 5 };
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            bool unique = true;
            for (int j = 0; j < a.Length; j++)
                if (i != j && a[i] == a[j])
                    unique = false;

            if (unique) count++;
        }

        Console.WriteLine("Количество уникальных элементов: " + count);
    }
}
