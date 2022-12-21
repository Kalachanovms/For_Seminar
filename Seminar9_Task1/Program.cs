// Задайте значение N. Напишите программу, которая выведет все натуральные числа от 1 до N

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

string ShowNumber(int n)
{
    if(n == 1) return "1";
    return ShowNumber(n-1)+ " " + n;
}
Console.Clear();
int number = DataEntry("Введите натуральное чило : ");
System.Console.WriteLine(ShowNumber(number
));