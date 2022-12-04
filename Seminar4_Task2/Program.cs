// Напишите программу, которая принимает на вход число и выдает количество цифр в числе 
// 456 -> 3
// 78 - >
// 89126 -> 5

Console.Clear();

int DataEntry(string str)
{
    Console.WriteLine(str);
    int numberOne = int.Parse(Console.ReadLine());
    return numberOne;
}

int Digits(int number)
{
    int i = 0;

    for (i = 0; number > 0; i++)
    {
        number = number / 10;
    }
    return i;
}

int FiveUnitNumber = DataEntry("Write number: ");
int result = Digits(FiveUnitNumber);
Console.WriteLine("Количество цифр в числе : " + result);



