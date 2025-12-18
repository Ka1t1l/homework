using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int lastTwo = n % 100;
        int last = n % 10;

        string word;

        if (lastTwo >= 11 && lastTwo <= 14)
            word = "рублей";
        else if (last == 1)
            word = "рубль";
        else if (last >= 2 && last <= 4)
            word = "рубля";
        else
            word = "рублей";

        Console.WriteLine($"{n} {word}");
    }
}
