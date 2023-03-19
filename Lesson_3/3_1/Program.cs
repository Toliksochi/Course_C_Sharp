void Quaters(int x)
{
    if (x == 1)
        Console.WriteLine ("x > 0, y = 0");
    else if (x == 2)
        Console.WriteLine ("x < 0, y > 0");
    else if (x == 3)
        Console.WriteLine ("x < 0, y < 0");
    else if (x == 4)
        Console.WriteLine ("x > 0, y < 0");
    else
        Console.WriteLine ("Error");
}

int x = int.Parse (Console.ReadLine ()!);

Quaters (x);
