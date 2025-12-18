using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        double[] c = { 1,2,3,4,5,6,7,8,9,10,11 };
        double y = c[0];

        for (int i = 1; i < c.Length; i++)
            y = y * x + c[i];

        Console.WriteLine("y = " + y);
    }
}
