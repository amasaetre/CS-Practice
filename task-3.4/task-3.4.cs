using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество членов ряда Фибоначчи: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ожидаемый результат:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
    
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}