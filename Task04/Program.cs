Console.Clear();

void Tablesquare(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while ( count <= number)
    {
        int pow = count*count;
        Console.Write(pow + " ");
        count ++;
    
    }
        Console.WriteLine();
}

Tablesquare("Write number N : ");