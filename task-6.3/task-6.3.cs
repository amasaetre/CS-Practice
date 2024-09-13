using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите элементы массива, разделенные запятыми (например: hello, 1811, goodbye):");
        string userInput = Console.ReadLine();
        
        string[] elements = userInput.Split(',');
        
        List<string> stringList = new List<string>();

        foreach (string element in elements)
        {
            string trimmedElement = element.Trim();
            if (int.TryParse(trimmedElement, out int number))
            {
                stringList.Add(number.ToString());
            }
            else
            {
                stringList.Add(trimmedElement);
            }
        }
        
        string[] stringArray = stringList.ToArray();
        
        Console.WriteLine("Результат преобразования:");
        foreach (string item in stringArray)
        {
            Console.WriteLine($"'{item}'");
        }
    }
}