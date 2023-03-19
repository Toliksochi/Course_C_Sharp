// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Kub (int x)
{
    int i = 1;
    while (i <= x)
    {
        Console.Write ($"{i*i*i}, ");
        i = i+1;
    }       
}
Console.WriteLine ("Введите число");
int num = int.Parse (Console.ReadLine ()!);
Kub (num);
