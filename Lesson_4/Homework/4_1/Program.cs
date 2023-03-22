//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Решение через цикл

int Step_1 (int a, int b)
{
    int n = 1;
    for (int i = 1; i <= b; i++)
    {
        if (i>0)
            n *= a;
        else
            break;
    }
    return n;
}

//Решение через Math.Pow

void Step_2 (int a, int  b)
{
    double n = 0;
    n = Math.Pow (a, b);
    Console.WriteLine (n);         
}


Console.WriteLine ("Введите два числа");
int num_1 = int.Parse (Console.ReadLine ()!);
int num_2 = int.Parse (Console.ReadLine ()!);
Console.WriteLine("");
Console.WriteLine (Step_1 (num_1, num_2));
Console.WriteLine("");
Step_2 (num_1, num_2);