// Напишите программу, которая принимает на вход число N и выдает произведенеие чисел от 1 до N.
// 4 - 24
// 5 - 120

Console.Clear();

int DataInput(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindComposition(int number)
{
    int mult = 1;

    for (int i = 1; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}

int number = DataInput("Write you number : ");
int mult = FindComposition(number);

Console.WriteLine("Произведение чисел до " + number + " = " + mult);