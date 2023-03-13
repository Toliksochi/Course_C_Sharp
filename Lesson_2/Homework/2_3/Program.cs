void Takenum(int num)
{
    Console.WriteLine (num);
    if (num < 100)
    {
        Console.WriteLine ("У заданного числа третьей цифры нет");
    }
    else
    {
        string i = num.ToString();
        Console.WriteLine (i[2]); 
    }
        
}

Takenum(new Random().Next());


