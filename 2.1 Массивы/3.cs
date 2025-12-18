using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 2, 1, 4, 4 };

        int maxLen = 1, start = 0;

        for (int center = 0; center < a.Length; center++)
        {
            Expand(center, center);
            Expand(center, center + 1);
        }

        void Expand(int l, int r)
        {
            while (l >= 0 && r < a.Length && a[l] == a[r])
            {
                if (r - l + 1 > maxLen)
                {
                    maxLen = r - l + 1;
                    start = l;
                }
                l--; r++;
            }
        }

        Console.Write("Подпоследовательность: ");
        for (int i = start; i < start + maxLen; i++)
            Console.Write(a[i] + " ");
    }
}
