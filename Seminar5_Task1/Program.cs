// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
array = FillArrayNew(size, leftRange, rightRange);
System.Console.Write("Все значения массива");
System.Console.WriteLine('[' + string.Join(",", array) + ']');


for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i]; // Выводи массива с отрицательными значениями;
}

System.Console.Write("Отрицательные значения, после работы кода");
System.Console.WriteLine('[' + string.Join(",", array) + ']');





