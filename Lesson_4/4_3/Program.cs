void Massiv (int x)
{
    int[] arr = new int [x];
    for (int i =0; i < x; i++)
    {
        arr [i] = new Random().Next(2);
        Console.Write (arr[i]+ ", ");
    }
}

Massiv (int.Parse (Console.ReadLine()!));