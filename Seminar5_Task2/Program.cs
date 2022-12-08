// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
Console.Clear();


const int size = 12;
const int leftRange = -9;
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

void SumPositiveAndNegative(int[] arr, out int SumP, out int SumN)
{
    SumP = 0;
    SumN = 0;

    for (int i = 0; i < arr.Length; i++) // Вводим 2 переменных и суммируем положительные и отрицательные числа
    {
        if (arr[i] > 0)
        {
            SumP += arr[i];  // += это SumPositive = Sumpositive + array[i]; // index = index + 1 // index ++ // index +=1
        }
        else
        {
            SumN += arr[i];
        }
    }
}

array = FillArrayNew(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join(",", array) + ']'); // Позволяет вывести весь массив через определенные знаки препинания 
SumPositiveAndNegative(array, out int SumP, out int SumN); // out int + переменная, позволяет вернуть данные с невозвратным методом 

System.Console.WriteLine($"Сумма положительных чисел массива = {SumP}");
System.Console.WriteLine($"Сумма отрицательных чисел массива = {SumN}");
