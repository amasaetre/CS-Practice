using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = RequestFileName();
        Console.Write("Введите расположение папки (или '-' для папки проекта): ");
        string folderLocation = Console.ReadLine();

        CreateFile(fileName, folderLocation);
    }

    // Запрос
    static string RequestFileName()
    {
        Console.Write("Введите имя файла: ");
        return Console.ReadLine();
    }

    // Создание
    static void CreateFile(string fileName, string folderLocation)
    {
        string path;


        if (folderLocation == "-")
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }
        else
        {
            // Иначе создаём файл в указанной папке
            path = Path.Combine(folderLocation, fileName);
        }

        try
        {

            if (!File.Exists(path))
            {

                File.Create(path).Dispose();
                Console.WriteLine($"Файл '{fileName}' успешно создан по пути: {path}");
            }
            else
            {
                Console.WriteLine($"Файл '{fileName}' уже существует.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
        }
    }
}