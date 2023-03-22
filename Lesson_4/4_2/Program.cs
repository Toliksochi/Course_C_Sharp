int SumNum (int num)
{
    int kol =1;
    for (int i = 1; i <= num; i++)
    {
        kol *= i;
    }
    return kol;
}
int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);