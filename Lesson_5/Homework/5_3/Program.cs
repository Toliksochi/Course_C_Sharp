/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива. */


void Print (double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write ($"{arr[i]:F2}; ");
    Console.WriteLine();
}

double [] MassNums (int size, int begin, int end)
{
    double [] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        arr [i] = rnd.NextDouble() * (end - begin) + begin;
    return arr;
}
double difference (double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max )
            max = arr[i];
            
        else if (arr[i] < max && arr[i] < min)
            min = arr[i];
        else
            continue;                                                     
    }
    double difference = max - min;
    Console.WriteLine ($"Максимальное значение массива равно: {max:F2}");
    Console.WriteLine ($"Минимальное значение массива равно: {min:F2}");
    return difference;
}

Console.WriteLine ("Введите длину массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите начальное значение массива");
int begin = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите конечное значение массива");
int end = int.Parse(Console.ReadLine()!);
double[] mass = MassNums (num, begin, end);
Console.Write ("Массив состоит из следующих значений: ");
Print (mass);
Console.WriteLine ($"Разница между максимальным и минимальным значением равна: {difference(mass):F2}");