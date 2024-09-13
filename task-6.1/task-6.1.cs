﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер месяца (1-12): ");
        if (int.TryParse(Console.ReadLine(), out int monthNumber))
        {
            string monthName = GetMonthName(monthNumber);
            Console.WriteLine(monthName);
        }
        else
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 12.");
        }
    }
    
    static string GetMonthName(int monthNumber)
    {
        switch (monthNumber)
        {
            case 1:
                return "Январь";
            case 2:
                return "Февраль";
            case 3:
                return "Март";
            case 4:
                return "Апрель";
            case 5:
                return "Май";
            case 6:
                return "Июнь";
            case 7:
                return "Июль";
            case 8:
                return "Август";
            case 9:
                return "Сентябрь";
            case 10:
                return "Октябрь";
            case 11:
                return "Ноябрь";
            case 12:
                return "Декабрь";
            default:
                return "Неверный номер месяца. Пожалуйста, введите число от 1 до 12.";
        }
    }
}