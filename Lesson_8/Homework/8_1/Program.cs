/* Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. */

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

void Findmin (int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min = arr[0, 0];
   
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (arr[i, j] < min)
                min = arr[i, j];
        } 
          /* Дальше не смог придумать как решить((( Не получается из минимума вытащить позиции,
           которые в новом масиве можно было бы пропустить и вывести новый массив  */             
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
Print(mass);
Findmin(mass);



