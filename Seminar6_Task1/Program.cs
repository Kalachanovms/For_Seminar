// Напишите программу, которая перевернет одномерный массив ( последний лемент будет на первом месте, а первый на последнем  и тд )
Console.Clear();

const int size = 5;
const int leftRange = 1;
const int rightRange = 6;

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

void ReversArray(int[] array) // перевернуть массив 
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array [array.Length -1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

array = FillArrayNew(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join(",", array) + ']');
ReversArray(array);
System.Console.WriteLine('[' + string.Join(",", array) + ']');
