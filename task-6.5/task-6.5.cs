using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделенные запятыми (например: 881, laugh, 16, b, k, programming):");
        string userInput = Console.ReadLine();
        
        string[] elements = userInput.Split(',');
        
        object[] mixedArray = ConvertToObjectArray(elements);
        
        object[] filteredArray = FilterArray(mixedArray);
        
        Console.WriteLine("Результат фильтрации:");
        foreach (object item in filteredArray)
        {
            Console.WriteLine(item);
        }
    }
    
    static object[] ConvertToObjectArray(string[] elements)
    {
        var result = new List<object>();
        
        foreach (string element in elements)
        {
            string trimmedElement = element.Trim();

            if (int.TryParse(trimmedElement, out int number))
            {

                result.Add(number);
            }
        }
        
        return result.ToArray();
    }
    
    static object[] FilterArray(object[] array)
    {
        var result = array.OfType<int>().Cast<object>().ToArray();

        return result;
    }
}