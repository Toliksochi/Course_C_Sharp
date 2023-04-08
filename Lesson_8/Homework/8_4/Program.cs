// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];   
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);            
    return arr;   
}

void CompMass (int [,] arr, int [,] arr_1)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] resultarr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            resultarr[i,j] = 0;
            for (int k = 0; k < column; k++) 
            {
                resultarr[i,j] += arr[i,k]*arr_1[k,j]; 
                     
            }
            Console.Write("{0,3}", resultarr[i,j]);
        }    
        Console.WriteLine();    
    }             
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
int[,] mass_2 = MassNums(num_row, num_column, start, stop);


if (num_row != num_column)
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}

Print(mass);
Print(mass_2);
CompMass (mass, mass_2);


