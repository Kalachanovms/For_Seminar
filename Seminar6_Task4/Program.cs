﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

int Data(string str) // Метод прочтения строки ;
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int [] ConvertTOF(int number) // метод вывода чисел фибоначи
{
    int[] array = new int[number];
    array[0] =0;
    array[1] = 1;
    for ( int index = 2; index < number;index++)
    {
        array[index] = array[index - 2] + array[index - 1];
    }
    return array;

}
int a = Data("Введите число :");
int [] arr = ConvertTOF(a);
System.Console.WriteLine("[" + string.Join(",", arr) + "]");