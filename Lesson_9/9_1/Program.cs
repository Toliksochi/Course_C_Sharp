/* задайте значения M и N. напишите программу, 
которая рекурсивно выведет все натуральные числа в промежутке от M и N */

void ValuesSet (int M, int N)
{
    if (N < M) return;
    ValuesSet(M, N-1);
    Console.Write($"{N} ");
}


int num  = int.Parse (Console.ReadLine()!);
int num_2  = int.Parse (Console.ReadLine()!);
ValuesSet (num, num_2);