// Задача 59
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец на пересечении которых расположен наименьший элемент массива.

int[,] CreateRandomArray(int rows, int columns, int leftrange, int rirghtrange) // метод создания массива
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftrange, rirghtrange + 1);
        }
    }
    return array;
}


void PrintArray(int[,] array)// метод вывода массива 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            System.Console.Write($"[{array[i, j]}]");

        }
        System.Console.WriteLine();
    }

}

int EnterNumber(string message) // метод чтения строки
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("Введите значение m : "); // значение массива
int n = EnterNumber("Введите значение n : "); // значение массива


int[,] matrix = CreateRandomArray(m, n, 0, 10); // 0-10 диапазон , m/n высота/ширина
PrintArray(matrix); // печать массива



int min1 = 0;
int min2 = 0;
int min = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            min1 = i;
            min2 = j;
        }

    }
}

System.Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i != min1 && j != min2)
            System.Console.Write("[" + matrix[i, j] + "]");
    }
    if (i != min1)
        System.Console.WriteLine();
}