// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

Console.Clear();
int number = Promt("Введите число: ");
for (int i = 1; i <= number; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}
