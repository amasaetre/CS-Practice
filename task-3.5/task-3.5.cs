using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите базовое значение: ");
        int baseValue = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите экспоненту: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        int result = Power(baseValue, exponent);

        Console.WriteLine($"Значение {baseValue} в степени {exponent} равно: {result}");
    }
    
    static int Power(int baseValue, int exponent)
    {
        if (exponent == 0)
            return 1;
        
        return baseValue * Power(baseValue, exponent - 1);
    }
}