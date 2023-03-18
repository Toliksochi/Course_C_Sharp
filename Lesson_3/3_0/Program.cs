void Quaters(int x, int y)
{
    if (x == 0 || y ==0)
        Console.WriteLine ("x = 0, y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine ("Четверть I");
    else if (x < 0 && y > 0)
        Console.WriteLine ("Четверть II");
    else if (x < 0 && y < 0)
        Console.WriteLine ("Четверть III");
    else
        Console.WriteLine ("Четверть IV");
}

int num_1 = int.Parse (Console.ReadLine ()!);
int num_2 = int.Parse (Console.ReadLine ()!);
Quaters (num_1, num_2);