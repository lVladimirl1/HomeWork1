// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
int SumOfNaturalElements (int M, int N)
{
    if (M > N) 
    {
        return 0;
    }
   return M+SumOfNaturalElements(M+1,N);
}

Console.WriteLine("Введите начальное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ($"Сумма натуральных элементов = {SumOfNaturalElements(M, N)}");
