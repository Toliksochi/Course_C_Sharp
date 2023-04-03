// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Print (int [,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)   
            Console.Write ($" {arr[i,j]} ");
        Console.WriteLine();    
    }        
    Console.WriteLine();
}

int [,] MassNums (int row, int column, int from, int to)
{
    int [,] arr = new int [row, column];
    
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i,j] = new Random().Next(from, to);
    return arr;
    
}

void Average (int [,] arr)
{
    double count = 0;
    for (int j=0; j < arr.GetLength(1); j++)
    {
       for (int i=0; i < arr.GetLength(0); i++)
       {
            count +=arr[i,j];                                             
       }
       count = count / arr.GetLength(0);
       Console.WriteLine ($" В {j+1} столбце среднее аримфетичекое: {count :F2} ");
       count = 0;
    }      
    Console.WriteLine(); 
}


Console.WriteLine("Укажите количество строк");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите количество столбцов");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите начало диапазона");
int start = int.Parse (Console.ReadLine()!);
Console.WriteLine("Укажите конец диапазона");
int stop = int.Parse (Console.ReadLine()!);


int[,] mass = MassNums (num_row, num_column, start, stop);
Print (mass);
Average (mass);