﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number >= 5 && number <= 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
    }
}
