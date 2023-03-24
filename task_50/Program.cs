// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrixWithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}



void PrintMatrix(int[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write(matrix[i,j] + " ");
}
Console.WriteLine();
}
}

System.Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5,5];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
{
    Console.WriteLine($"Элемент {row} строки  {column} столбца = {matrix[row-1,column-1]}");       
}
else
{
    Console.WriteLine("такого числа в массиве нет");
}
 
