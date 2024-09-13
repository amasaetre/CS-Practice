using System;

class Program
{
    static void Main()
    {
        Console.Write("Сколько чисел нужно сложить: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int result = SumNumbers(n);
        
        Console.WriteLine($"Ожидаемый результат: {result}");
    }
    
    static int SumNumbers(int n)
    {
        if (n == 1)
            return 1;

        return n + SumNumbers(n - 1);
    }
}