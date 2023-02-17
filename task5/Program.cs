// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string result = number.ToString();
int i = 1;

void SecondDigitNumber()
{
    if (number > 99 & number < 999)
    {
        Console.WriteLine($"Вторая цифра числа: {result[i]}");

    }
    else
    {
        Console.WriteLine("Это не трёхзначное число");
    }
}
SecondDigitNumber();