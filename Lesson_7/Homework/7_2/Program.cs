/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

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

string Example (int [,] array, int num_1, int num_2)
{
    
    if (num_1 <= array.GetLength(0) && num_2 <= array.GetLength(1))
        return ($"{array[num_1-1, num_2-1]}");        
       
    else
        return ("такого числа нет в массиве"); 
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
Console.WriteLine("Укажите позицию в строке");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите позицию в столбце");
int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ($"{Example (mass , num_1, num_2)}");

