/* Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1. */

void Fib (int num)
{
    int A = 0;
    int B = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write (A+" ");
        (A,B) = (B, A+B);
    }
}
int Z = int.Parse(Console.ReadLine()!);
Fib(Z);