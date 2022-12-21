// Напишите программу, которая будет принимать число и выводить сумму его цифр  

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void SumNumbers (int num, int sum)
{
    sum += num % 10;
    if (num > 0)
    {
        SumNumbers(num / 10, sum);
    }
    else System.Console.WriteLine(sum);
}
int sum = 0;
int num = DataEntry("Введите число : ");
System.Console.Write("Сумма цифр введенного числа равна : ");
SumNumbers(num, sum);

