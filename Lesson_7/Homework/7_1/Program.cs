// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Print (double [,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)   
            Console.Write ($" {arr[i,j]:F2} ");
        Console.WriteLine();    
    }        
    Console.WriteLine();
}

double [,] MassNums (int row, int column, int from, int to)
{
    double [,] arr = new double [row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i,j] = rnd.NextDouble()*(to-from)+from;
    return arr;
}

Console.WriteLine("Укажите количество строк");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите количество столбцов");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите начало диапазона");
int start = int.Parse (Console.ReadLine()!);
Console.WriteLine("Укажите конец диапазона");
int stop = int.Parse (Console.ReadLine()!);


double[,] mass = MassNums (num_row, num_column, start, stop);
Print (mass);
