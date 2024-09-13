using System;

class Program
{
    static void Main()
    {
        Console.Write("Сколько чисел нужно напечатать: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Результат:");
        PrintNumbers(1, n);
    }
    
    static void PrintNumbers(int current, int n)
    {
        if (current > n)
            return;

        Console.Write(current + " ");
        PrintNumbers(current + 1, n);
    }
}