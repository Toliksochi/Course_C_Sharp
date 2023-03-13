void Weekend(int num)
{
    if (num > 5 && num < 8)
    {
        Console.WriteLine ("Вы выбрали выходной");   
    }
    else if (num >= 1 && num < 6)
    {
        Console.WriteLine ("Вы выбрали рабочий день");
    }
    else
    {
        Console.WriteLine ("Вы ввели неверное число, попробуйте еще раз");
    }    
}
Console.WriteLine ("Введите число от 1 до 7");
Weekend(int.Parse (Console.ReadLine()!));