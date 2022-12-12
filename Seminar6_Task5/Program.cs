// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();


const int size = 10;
const int leftRange = 1;
const int rightRange = 9;

int[] array = new int[size];

int[] FillArrayNew(int size, int leftRange, int rightRange) //Метод для создания массива с любым количеством знаков
{
    Random rand = new Random(); // Переменная класса Random

    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] CopyArray(int[] arr) // метод копирования массива
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}

int[] firstArray = FillArrayNew(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join(",", firstArray) + ']'); // вывод массива

int[] secondArray = CopyArray(firstArray);
System.Console.WriteLine('[' + string.Join(",", secondArray) + ']');



