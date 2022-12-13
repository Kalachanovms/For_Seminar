// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}");
            
        }
        System.Console.WriteLine();
    }

}

// 1. Получить от пользователя M/N
int[,] CreateRandomArray(int rows, int columns, int leftrange, int rirghtrange)
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

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int m = EnterNumber("Введите значение m : ");
int n = EnterNumber("Введите значение n : ");

// 2. Создаем двухмерный массив и заполняем его

int[,] matrix = CreateRandomArray(m, n, 0, 10);

// 3. Вывести массив 

PrintArray(matrix);




