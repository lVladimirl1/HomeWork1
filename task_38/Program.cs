// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] FillArrayWithRandomNumbers(int length)
{
    double[] arr = new double[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,10);
    }
    return arr;
}

Console.Clear();
System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
double min = int.MaxValue;
double max = int.MinValue;

for (int i = 0; i< array.Length; i++)
{
if (array[i]<min)

{
    min= array[i];
}
if (array[i]>max)
{
    max = array[i];
}
}
System.Console.WriteLine($"{max} и {min} разница между ними {max-min}");

