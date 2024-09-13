using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Введите путь к файлу: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            ReadSpecificLines(filePath, new int[] { 1, 3, 5 });
        }
        else
        {
            Console.WriteLine("Файл не существует.");
        }
    }
    
    static void ReadSpecificLines(string filePath, int[] linesToRead)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (int lineNumber in linesToRead)
            {
                if (lineNumber - 1 < lines.Length)
                {
                    Console.WriteLine($"Строка {lineNumber}: {lines[lineNumber - 1]}");
                }
                else
                {
                    Console.WriteLine($"Строка {lineNumber} не существует в файле.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
        }
    }
}