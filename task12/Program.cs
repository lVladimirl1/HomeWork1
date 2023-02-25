// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Promt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumOfNambers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}


Console.Clear();
int number = Promt("Введите число ");
System.Console.WriteLine($"Сумма чисел {number} равна {SumOfNambers(number)} ");
