using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 3, 3, 2, 3, 1 };

        int maxCount = 0, element = a[0];

        for (int i = 0; i < a.Length; i++)
        {
            int cnt = 0;
            for (int j = 0; j < a.Length; j++)
                if (a[i] == a[j]) cnt++;

            if (cnt > maxCount)
            {
                maxCount = cnt;
                element = a[i];
            }
        }

        Console.WriteLine($"Элемент: {element}, количество: {maxCount}");
    }
}
