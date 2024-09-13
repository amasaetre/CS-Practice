using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первую строку:");
        string firstString = Console.ReadLine();

        Console.WriteLine("Введите вторую строку:");
        string secondString = Console.ReadLine();

        CompareStrings(firstString, secondString);
    }
    
    static void CompareStrings(string str1, string str2)
    {
        int comparisonResult = string.Compare(str1, str2);

        if (comparisonResult > 0)
        {
            Console.WriteLine("Первая строка больше второй.");
        }
        else if (comparisonResult < 0)
        {
            Console.WriteLine("Первая строка меньше второй.");
        }
        else
        {
            Console.WriteLine("Строки равны.");
        }
    }
}