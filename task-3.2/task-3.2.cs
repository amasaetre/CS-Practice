using System;

class Program
{
    static void Main()
    {
        Console.Write("Сколько чисел нужно напечатать: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат:");
        PrintNumbers(n);
    }
    
    static void PrintNumbers(int n)
    {
        if (n < 1)
            return;

        Console.Write(n + " ");
        PrintNumbers(n - 1);
    }
}