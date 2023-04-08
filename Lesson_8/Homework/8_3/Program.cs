/*  Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. */

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}    
    

int [,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;       
}

void MinSumm (int [,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int minrow = 0;
    int summrow = 0;
    int minsumrow = 0;

    for (int i = 0; i < column; i++)
    {
        minrow += arr[0,i];          
    }   
    for (int i = 0; i < row; i++)
    {    
        for (int j = 0; j < column; j++)
            summrow += arr[i,j];
            if (summrow < minrow)
            {
                minrow = summrow;
                minsumrow = i;
            }
        summrow = 0;
    }
    Console.Write($" Минимальная сумма составляет {minrow} и находится в {minsumrow + 1} строке");    
}



Console.WriteLine("Укажите количество строк");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите количество столбцов");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите начало диапазона");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите конец диапазона");
int stop = int.Parse(Console.ReadLine()!);
    
int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
MinSumm(mass);