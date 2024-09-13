using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Введите слово для поиска:");
        string wordToFind = Console.ReadLine();

        int count = CountWordOccurrences(sentence, wordToFind);

        Console.WriteLine($"Слово \"{wordToFind}\" встречается {count} раз(а).");
    }
    
    static int CountWordOccurrences(string sentence, string word)
    {
        if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(word))
            return 0;
        
        sentence = sentence.ToLower();
        word = word.ToLower();
        
        string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;
        foreach (string w in words)
        {
            if (w == word)
            {
                count++;
            }
        }

        return count;
    }
}