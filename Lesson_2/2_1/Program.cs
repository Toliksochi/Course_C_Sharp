
int Takenum(int num)
{
    Console.WriteLine (num);
    int a = num %10;
    int b = num/10;
    if (a>b)
    {
     return a;
    }
    else
    {
     return b;
    }
}

int result = Takenum (new Random().Next (10,100));
Console.WriteLine (result);