/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. */

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
        arr[i] = new Random().Next(-100, 100);
    return arr;
}

void SumMas(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]>0)
            count+=1;
        else
            continue;
    }
    Console.WriteLine (count);        
}

Console.WriteLine ("Введите количество элементов:");
int num = int.Parse(Console.ReadLine()!);
int[] mass = MassNums (num);
Print (mass);
SumMas(mass);
