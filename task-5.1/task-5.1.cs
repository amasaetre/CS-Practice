using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        int length = CalculateStringLength(input);

        Console.WriteLine($"Длина строки: {length}");
    }
    
    static int CalculateStringLength(string str)
    {
        int length = 0;
        
        foreach (char c in str)
        {
            length++;
        }

        return length;
    }
}