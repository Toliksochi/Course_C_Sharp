/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. */

void Print (int [] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write ($"{arr[i]} ");
    Console.WriteLine();
}

int [] MassNums (int size)
{
    int [] arr = new int [size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}
int SumPosNeg  (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;                                                     
    }
    return count;
}

int num = int.Parse(Console.ReadLine()!);
int[] mass = MassNums (num);
Print (mass);
Console.WriteLine (SumPosNeg(mass));