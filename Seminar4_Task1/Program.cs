// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Метод - получить число;

int FindSum(int number)
{
    int sum = 0;

    for(int i = 1; i <= number; i++)
    {
    sum = sum + i;
    }
    return sum;
}

int number = DataEntry("Write you number : ");
int result = FindSum(number);

Console.WriteLine("Сумма всех чисел до А = " + result);