// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
 
   return result;
}
int[] ImputArray (int length)
{
    int[] array = new int [length];
    for (int i =0; i< array.Length; i++)
    {
        array[i] = Prompt ($"Введите {i+1}-й элемент ");
    }
    return array;
}


int CountPositiveNumbers (int[] array)
{
int count =0;
for (int i = 0; i< array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
return count;
}

int length = Prompt("Количество элементов >");
int[] array;
array = ImputArray(length);
System.Console.WriteLine($"[ {string.Join(", ", array )}] ");
System.Console.Write($"Количество чисел>0 - {CountPositiveNumbers(array)}");