// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Summa(int A)
{
    int n = 0;
    for (int i = 1; A > 0; i++)
    {
        if (i>0)
        {
            int Z = A%10;
            A = A/10;
            n += Z;
        }
        else
            break;
    }
    return n;
}
Console.WriteLine ("Введите числo");
int num_1 = int.Parse (Console.ReadLine ()!);
Console.WriteLine (Summa(num_1));