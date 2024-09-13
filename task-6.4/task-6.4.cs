using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string binaryString = Convert.ToString(number, 2);
            int countOfOnes = CountOnesInBinary(binaryString);

            Console.WriteLine($"Число в бинарном формате: {binaryString}");
            Console.WriteLine($"Количество единиц: {countOfOnes}");
        }
        else
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
        }
    }
    
    static int CountOnesInBinary(string binaryString)
    {
        int count = 0;
        foreach (char c in binaryString)
        {
            if (c == '1')
            {
                count++;
            }
        }
        return count;
    }
}