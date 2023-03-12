// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);

int Z = 1;

while (Z <= N)
{
    if (Z % 2 == 0)
    {
        Console.Write(Z + ", ");
        Z = Z + 2;
    } 
    else
    {
        Z = Z +1;
    }
}

