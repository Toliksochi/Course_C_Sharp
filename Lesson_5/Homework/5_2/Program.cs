/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
 */

void Print (int [] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write ($"{arr[i]} ");
        
    Console.WriteLine();
}

int [] MassNums (int size)
{
    int [] arr = new int [size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-10, 20);
    return arr;
}

int SumNech (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        if (arr[i] > 0)
            count += arr[i];                                                                      
    }
    return count;
       
}
void Print_1 (int [] arr) // Метод вывода полученных значений, находящихся на нечетных позициях
{
    int size = arr.Length;
    for (int i = 0; i < size; i+=2)
        Console.Write ($"{arr[i]} ");
        
    Console.WriteLine();
}

Console.WriteLine ("Введите длину массива");
int num = int.Parse(Console.ReadLine()!);
int[] mass = MassNums (num);
Console.Write ($"Массив состоит из следующих чисел: ");
Print (mass);
Console.Write ($"Нечетные позиции занимают числа: ");
Print_1 (mass);
Console.Write ($"Их сумма равна: {SumNech(mass)}");