using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };

        bool isSet = true;
        for (int i = 0; i < a.Length; i++)
            for (int j = i + 1; j < a.Length; j++)
                if (a[i] == a[j])
                    isSet = false;

        Console.WriteLine(isSet
            ? "Массив образует множество"
            : "Массив НЕ образует множество");
    }
}
