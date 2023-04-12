/* Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр. использовать рекурсию */


int ValuesSet (int M)
{
    if (M == 0 ) return 0;
    return ValuesSet (M/10)+ M % 10;    
}

int num  = int.Parse (Console.ReadLine()!);
Console.WriteLine (ValuesSet(num));
