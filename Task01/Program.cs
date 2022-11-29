Console.Clear();
int DataEntryXY(string str)
{
    Console.WriteLine(str);
    int line = int.Parse(Console.ReadLine());
    return line;
}
void FindQandrat( int x, int y)
{
    if ((x > 0) && ( y > 0 )) Console.WriteLine("This first qandrat");
    if ((x < 0) && ( y > 0 )) Console.WriteLine("This second qandrat");
    if ((x < 0) && ( y < 0 )) Console.WriteLine("This third qandrat");
    if ((x > 0) && ( y < 0 )) Console.WriteLine("This four qandrat");
}

int x = DataEntryXY("write find x = ");
// Console.WriteLine(x);
int y = DataEntryXY("write find y = ");
// Console.WriteLine(y);
FindQandrat(x,y);