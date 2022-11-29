Console.Clear();

int DataEntry(string str)
{
    Console.WriteLine(str);
    int line = int.Parse(Console.ReadLine());
    return line;
}

double CalcDistance(int x, int y, int x1, int y1)
{

    double result = Math.Sqrt(Math.Pow(x1- x,2) + Math.Pow(y1 - y,2));
    return result;
}

int x = DataEntry("Введите координаты X : = ");
int y = DataEntry("Введите координаты Y = ");

int x1 = DataEntry("Введите координаты X1 = ");
int y1 = DataEntry("Введите координаты Y1 = ");

double distance = CalcDistance(x, y, x1, y1);
Console.WriteLine(distance);