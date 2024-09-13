using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        
        HashSet<char> uniqueChars = new HashSet<char>();
        
        int totalChars = 0;

        foreach (char c in input)
        {
            
            if (c != ' ')
            {
                totalChars++;
                
                if (!uniqueChars.Contains(c))
                {
                    uniqueChars.Add(c);
                }
            }
        }

        Console.WriteLine("Уникальные символы:");
        foreach (char c in uniqueChars)
        {
            Console.Write(c + " ");
        }

        Console.WriteLine();


        Console.WriteLine($"{uniqueChars.Count} / {totalChars}");
    }
}