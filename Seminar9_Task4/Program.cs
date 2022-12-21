// Напишите программу, которая на вход принимает 2 числа А и В , и возводит число А в целую степень В с помощью рекурсии.


int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int DegreeOfNumber(int num, int power)
{
   if(power <= 0) return 1;
   return DegreeOfNumber(num, power - 1)* num;

}

Console.Clear();
int num = DataEntry("Введите число А : ");
int power = DataEntry("Введите число B : ");

System.Console.WriteLine(DegreeOfNumber(num, power));