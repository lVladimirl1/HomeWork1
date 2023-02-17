// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


bool DayOfTheWeek (int number)
{
    if (number>5 && number<8)
    {
return true;
    }
    else
    return false;

}




Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool result = DayOfTheWeek(number);

if (result==true)
{
    System.Console.WriteLine($"{number} - Это выходной день");
}
else 
{
    System.Console.WriteLine($"{number} - Это не выходной день");;
}