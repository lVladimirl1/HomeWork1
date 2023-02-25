
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Promt(string massage)
{
System.Console.Write(massage);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int Calculations(int A, int B)
{
    int result=1;
    for (int i =1; i<=B; i++)
    {
        result = result*A;
    }
    return result;
}


Console.Clear();
int A = Promt("Введите число А: ");
int B = Promt("Введите число B: ");
System.Console.WriteLine(Calculations(A,B));