using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[3];

        for (int i = 0; i < 3; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Array.Sort(arr);
        Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]}");
    }
}
