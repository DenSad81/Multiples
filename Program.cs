﻿using System;

class Program
{
    static void Main(string[] args) {
        int startNumber = 50;
        int stopNumber = 150;
        int number;
        int quantityOfNumber = 0;
        int minNumber = 10;
        int maxNumber = 25;
        Random random = new Random();

        number = random.Next(minNumber, maxNumber + 1);
        Console.WriteLine("Число " + number);
        Console.WriteLine();

        for (int i = 0; i <= stopNumber; i += number)
        {
            if (i >= startNumber)
            {
                quantityOfNumber++;
                Console.WriteLine("Кратное число " + i);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Количество кратных чисел " + quantityOfNumber);
    }
}