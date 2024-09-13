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
            int lineCount = CountLinesInFile(filePath);
            Console.WriteLine($"Количество строк в файле: {lineCount}");
        }
        else
        {
            Console.WriteLine("Файл не существует.");
        }
    }
    
    static int CountLinesInFile(string filePath)
    {
        try
        {

            int lineCount = File.ReadAllLines(filePath).Length;
            return lineCount;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            return 0;
        }
    }
}