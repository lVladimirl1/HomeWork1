// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



double Distance3D(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(distance, 2);
}

Console.Clear();
Console.Write("Введите координату Х Первой точки : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y Первой точки : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z Первой точки : ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X Второй точки : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y Второй точки : ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z Второй точки : ");
double z2 = Convert.ToDouble(Console.ReadLine());


double result = Distance3D(x1, x2, y1, y2, z1, z2);
System.Console.WriteLine(result);



