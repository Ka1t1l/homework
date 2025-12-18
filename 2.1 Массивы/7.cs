using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 2, 3, 4, 4, 5 };
        int distinct = 0;

        for (int i = 0; i < a.Length; i++)
        {
            bool exists = false;
            for (int j = 0; j < i; j++)
                if (a[i] == a[j])
                    exists = true;

            if (!exists) distinct++;
        }

        Console.WriteLine("Количество различных элементов: " + distinct);
    }
}
