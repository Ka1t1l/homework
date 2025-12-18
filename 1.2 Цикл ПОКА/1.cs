using System;

class Program
{
    static void Main()
    {
        // Ввод целого числа
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        // Проверка, входит ли заданная цифра в число
        Console.Write("Введите цифру для поиска (0–9): ");
        char digit = Console.ReadLine()[0];

        bool containsDigit = number.ToString().Contains(digit);
        Console.WriteLine(containsDigit
            ? "Заданная цифра входит в число."
            : "Заданная цифра НЕ входит в число.");

        // Формирование числа с обратным порядком цифр
        int reversedNumber = ReverseNumber(number);
        Console.WriteLine($"Число с обратным порядком цифр: {reversedNumber}");

        // Проверка, является ли число числом Фибоначчи
        bool isFibonacci = IsFibonacci(number);
        Console.WriteLine(isFibonacci
            ? "Число является числом Фибоначчи."
            : "Число НЕ является числом Фибоначчи.");
    }

    // Метод для переворота числа
    static int ReverseNumber(int n)
    {
        int result = 0;
        n = Math.Abs(n);

        while (n > 0)
        {
            result = result * 10 + n % 10;
            n /= 10;
        }

        return result;
    }

    // Метод для проверки числа Фибоначчи
    static bool IsFibonacci(int n)
    {
        if (n < 0) return false;
        if (n == 0 || n == 1) return true;

        int f1 = 1, f2 = 1;

        while (f2 < n)
        {
            int f = f1 + f2;
            f1 = f2;
            f2 = f;
        }

        return f2 == n;
    }
}
