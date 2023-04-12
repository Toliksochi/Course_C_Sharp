/* Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.
 */

 int NaturSum (int M, int N)
 {
    if (N == M) return N;
    return NaturSum(M, N-1)+N;
}

int num_1  = int.Parse (Console.ReadLine()!);
int num_2  = int.Parse (Console.ReadLine()!);
Console.WriteLine(NaturSum(num_1, num_2));