using System;

class Program
{
    static void Main()
    {
        int[] a = { 3, 1, 5, 2, 6, 4 };
        int n = a.Length;
        int[] dp = new int[n];

        int max = 1;
        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
            for (int j = 0; j < i; j++)
                if (a[j] < a[i] && dp[j] + 1 > dp[i])
                    dp[i] = dp[j] + 1;

            if (dp[i] > max)
                max = dp[i];
        }

        Console.WriteLine("Длина подпоследовательности: " + max);
    }
}
