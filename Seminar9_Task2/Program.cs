// Задайте значение M и N . Напишите программу, которыая выведет все натуральные числа в промежутке от M до N.

void DataN(int m,int n)
{
    if(m <= n )
    {
        DataN(m,n -1 );
        Console.Write($"{n} ");
    }
}

System.Console.WriteLine(("Введите число M "));
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine(("Введите число N "));
int n = int.Parse(Console.ReadLine());
if(m>n) System.Console.WriteLine("Не корректный ввод");
else DataN(m,n);
