﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

void NaturalNumbers (int N)
{
   if (N == 0) 
   {
    return;
   }
    
    Console.Write(N+" ");
    NaturalNumbers (N - 1);
}



Console.WriteLine("Введите натуральное число:");
int N = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(N);