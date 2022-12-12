// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();

int Data(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Triangle(int a, int b, int c)
{
    if (a + b < c || a + c < b || b + c < a)
    {
        System.Console.WriteLine(" Это треугольник");
    }
}
int a = Data("Укажите длинну стороны а : ");
int b = Data("Укажите длинну стороны b : ");
int c = Data("Укажите длинну стороны c : ");

Triangle(a, b, c);

