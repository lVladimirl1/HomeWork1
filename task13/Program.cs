﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();

System.Console.WriteLine("Введите количество цыфр массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,99);
    
}
Console.Write('['+ string.Join(",", array) +']');