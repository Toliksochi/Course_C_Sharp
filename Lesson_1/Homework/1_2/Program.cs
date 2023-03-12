// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число C");
int c = int.Parse(Console.ReadLine()!);

int max = a;
int min = a;

if (a == b)
{
    if (a == c)
    {
        Console.WriteLine("Все числа равны");
    }
    if (a < c)
    {
        Console.WriteLine("Число C максимальное и равно " + c);
    }
    else if (a > c)
    {
        Console.WriteLine("Числа A и B максимальные и равны " + a);
    }
}
else if (a < b)
{
    max = b;

    if (b == c)
    {
        Console.WriteLine("Числа B и C максимальные и равны " + b);
    }
    else if (b > c)
    {
       Console.WriteLine("Число B максимальное и равно " + b); 
    }
    else 
    {
        Console.WriteLine("Число C максимальное и равно " + c);
    };
}
else if (a > c)
{
    Console.WriteLine("Число A максимальное и равно " + a);
}
else if (a < c)
{
    Console.WriteLine("Число C максимальное и равно " + c); 
}
else 
{
    Console.WriteLine("Числа A и C максимальные и равны " + a);
}

