// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i,j]} ");
            
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
            array[i, j] = i + j;
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