/* Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии. */

void ValuesSet (int N, int M)
{
    if (M < N) return;    
    ValuesSet(N, M-1);
    if (M % 2 == 0)
    Console.Write($"{M} ");
}

int num  = int.Parse (Console.ReadLine()!);
int num_2  = int.Parse (Console.ReadLine()!);
ValuesSet (num, num_2);
