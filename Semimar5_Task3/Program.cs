// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

const int size = 12;
const int leftRange = 0;
const int rightRange = 999;

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

array = FillArrayNew(size, leftRange, rightRange); // задаем методу переменную 
System.Console.WriteLine('[' + string.Join(",", array) + ']'); // Выводим массив данных

System.Console.WriteLine("Введите число для проверки : ");
int number = int.Parse(Console.ReadLine());

bool result = false; // используем булевое значение ( прав/ лож )
for (int i = 0; i < array.Length; i++)
{
    if(array[i] == number)// Сравниваем число из массива с введенной переменной
    {
       result = true;
        break; // останавливает цикл
    }
}

if(result) 
{
    System.Console.WriteLine("Число " + number + " cостоит в массиве данных");
}
else 
{
    System.Console.WriteLine("Число " + number + " не состоит в массиве данных");
}