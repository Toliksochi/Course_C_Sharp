/* Найдите произведение пар чиселв одномерном массиве.
 Парой считаем первый и последний, второй и предпоследний и т.д. Результат запишите в новом массиве */

void Print (int [] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write ($"{arr[i]} ");
    Console.WriteLine();
}

int [] MassNums (int size, int start, int stop)
{
    int [] arr = new int [size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(start, stop);
    return arr;
}

void SumPar (int[] arr)
{
    int count = 0;
    if (arr.Length%2==1) 
        count=arr.Length/2+1;			
    else 
        count=arr.Length/2;
    int [] new_arr = new int [count];     
    for (int i = 0; i < count ; i++)
    {
        if ((arr.Length%2==1) && (i==count-1)) 
            new_arr[i]=arr[i];	
        else 
            new_arr[i] = arr[i]*arr[arr.Length-i-1];		
    }
    Console.WriteLine (string.Join(",", new_arr));    
}   

Console.WriteLine ("Введите длину массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите начальное значение массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите конечное значение массива");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums (num, start, stop);

Print (mass);
SumPar(mass);
