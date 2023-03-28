/* Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой длины. */

void Triangle (int A, int B, int C)
{
    if (A < B + C && B < A + C && C < A +B )
        Console.WriteLine ("Существует");
    else
        Console.WriteLine("Не существует");
}
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
int num_3 = int.Parse(Console.ReadLine()!);
Triangle (num_1, num_2, num_3);