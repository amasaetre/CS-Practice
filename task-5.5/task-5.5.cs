using System;
using System.IO;

class Program
{
    static string filePath = "users.txt";

    static void Main()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Войти в систему");
        Console.WriteLine("2. Зарегистрироваться");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            AuthenticateUser();
        }
        else if (choice == "2")
        {
            RegisterUser();
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }
    
    static void CreateFileIfNotExists()
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
    }
    
    static void RegisterUser()
    {
        CreateFileIfNotExists();

        Console.Write("Введите логин: ");
        string login = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        // Запись логина и пароля в файл в новом формате
        using (StreamWriter sw = new StreamWriter(filePath, true))
        {
            sw.WriteLine($"Логин : {login}");
            sw.WriteLine($"Пароль : {password}");
            sw.WriteLine(); // Пустая строка для разделения записей
        }

        Console.WriteLine("Регистрация завершена!");
    }
    
    static void AuthenticateUser()
    {
        CreateFileIfNotExists();

        Console.Write("Введите логин: ");
        string login = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        string[] fileLines = File.ReadAllLines(filePath);
        bool loginFound = false;
        for (int i = 0; i < fileLines.Length; i++)
        {
            if (fileLines[i].StartsWith("Логин :"))
            {
                string storedLogin = fileLines[i].Substring(8).Trim();
                string storedPassword = fileLines[i + 1].Substring(9).Trim(); // Строка с паролем

                if (storedLogin == login)
                {
                    loginFound = true;
                    if (storedPassword == password)
                    {
                        Console.WriteLine("Вход успешно выполнен!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Неверный пароль.");
                        return;
                    }
                }
            }
        }

        if (!loginFound)
        {
            Console.WriteLine("Логин не найден. Хотите зарегистрироваться? (да/нет)");
            string registerChoice = Console.ReadLine();
            if (registerChoice.ToLower() == "да")
            {
                RegisterUser();
            }
        }
    }
}
