using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        string wordToCount = "Привет";
        int count = CountWordOccurrences(inputText, wordToCount);

        Console.WriteLine($"Количество упоминаний слова \"{wordToCount}\": {count}");
    }
    
    static int CountWordOccurrences(string text, string word)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(word))
            return 0;
        
        text = text.ToLower();
        word = word.ToLower();


        string pattern = $@"\b{Regex.Escape(word)}\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        return matches.Count;
    }
}