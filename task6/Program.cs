// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string result = number.ToString();
int i = 2;

void ThirdDigitNumber()
{
    if (number > 99)
    {
        Console.Write(result[i]);
        Console.Write("-Третья цифра числа");
    }
    else
    {
        Console.WriteLine($"Третьей цифры у числа {number} нет");
    }
}
ThirdDigitNumber();