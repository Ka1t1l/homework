using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 3, 2, 1 };

        if (a.Length != b.Length)
        {
            Console.WriteLine("Множества НЕ равны");
            return;
        }

        foreach (int x in a)
        {
            bool found = false;
            foreach (int y in b)
                if (x == y) found = true;

            if (!found)
            {
                Console.WriteLine("Множества НЕ равны");
                return;
            }
        }

        Console.WriteLine("Множества равны");
    }
}
