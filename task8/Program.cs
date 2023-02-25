// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
//  23432 -> 

string Promt(string message)
{
Console.Write(message);
string result = Console.ReadLine();
return result;
}

Console.Clear();
string number = Promt ("Введите пятизначное число: ");
int quantity = number.Length;
if (quantity == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine($"Число {number} - Палиндром");
        }
    else
        {
            Console.WriteLine($"Число {number} - НЕ палиндром");
        }
    }

    else
    {
        Console.WriteLine("Число не пятизначное!");
    }
