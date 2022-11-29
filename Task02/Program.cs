Console.Clear();

int DataEntry(string str)
{
    Console.WriteLine(str);
    int line = int.Parse(Console.ReadLine());
    return line;
}

void FindQuarter(int ch)
{

    if (ch == 1) Console.WriteLine (" x > 0 and y > 0");
    if (ch == 2) Console.WriteLine (" x < 0 and y > 0");
    if (ch == 3) Console.WriteLine (" x < 0 and y < 0");
    if (ch == 4) Console.WriteLine (" x > 0 and y < 0");
    
}
int ch = DataEntry("Введите четверть = ");

FindQuarter(ch);
