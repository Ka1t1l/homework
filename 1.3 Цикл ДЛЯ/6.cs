using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 999999; i++)
        {
            string s = i.ToString("D6");

            int sum1 = (s[0]-'0') + (s[1]-'0') + (s[2]-'0');
            int sum2 = (s[3]-'0') + (s[4]-'0') + (s[5]-'0');

            if (sum1 == sum2)
                Console.WriteLine(s);
        }
    }
}
