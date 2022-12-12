// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 45 -> 101101
// // 3 -> 11
// // 2 -> 10

// Console.Clear();

// int Data(string str) // Метод прочтения строки ;
// {
//     System.Console.WriteLine(str);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int Convert(int number)

// {
//     int ost;
//     while (number > 2)
//     {
//         ost = number % 2;
//         number = number / 2;
//     }
//     return ost;
// }

System.Console.WriteLine(" Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
GetBinaryView(N);

void GetBinaryView(int number) // перевод числа в двоичную систему 
{
    if (number <= 0)
    {
        return;
    }
    GetBinaryView(number / 2);
    System.Console.Write(" " + number % 2);
}
