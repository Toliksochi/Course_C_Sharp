// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Massiv (int x)
{
    int[] arr = new int [x];
    for (int i =0; i < x; i++)
    {
        arr [i] = new Random().Next(100);
        Console.Write (arr[i]+ ", ");
    }
}
Massiv (8);