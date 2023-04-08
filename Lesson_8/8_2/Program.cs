// Составить частотный словарь элементов двумерного массива.

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

int [] Dict (int[,] arr)
{
    int [] arr_new = new int[10];
    foreach (int a in arr) arr_new [a]++;
    return arr_new;    
}

void Print_2 (int [] arr) 
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine ($"{i} - {arr[i]}");
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
Print_2 (Dict (mass));
