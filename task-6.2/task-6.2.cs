using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите символ: ");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int charCode = GetCharCode(inputChar);

        Console.WriteLine($"Кодировка символа '{inputChar}' равна {charCode}");
    }
    
    static int GetCharCode(char character)
    {
        return (int)character;
    }
}