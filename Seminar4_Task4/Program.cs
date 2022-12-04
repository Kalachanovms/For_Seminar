Console.Clear();

int DataInput(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;

}

int[] FillArray(int[]array)
{
    int length = array.Length;
    int index = 0;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i;

    for (i = 0; i < count; i++)
    {
        Console.Write(col[i] + " ");
    }
}

int NumberN = DataInput("Введите число : ");
int[] array = new int [NumberN];
array = FillArray(array);
PrintArray(array);