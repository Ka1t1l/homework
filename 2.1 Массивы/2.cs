using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 5, 3, 4, 6, 1 };

        int maxLen = 1, curLen = 1, end = 0;

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > a[i - 1])
                curLen++;
            else
                curLen = 1;

            if (curLen > maxLen)
            {
                maxLen = curLen;
                end = i;
            }
        }

        Console.Write("Подпоследовательность: ");
        for (int i = end - maxLen + 1; i <= end; i++)
            Console.Write(a[i] + " ");
    }
}
