/* Напишите программу, которая на вход принимает два числа 
А и В и возводит число А в целую степень В при помощи рекурсии*/


int ValuesSet (int A, int B)
{
    if (B == 0) return 1;
    return ValuesSet (A, B-1) * A;    
}

int num_1  = int.Parse (Console.ReadLine()!);
int num_2  = int.Parse (Console.ReadLine()!);
Console.WriteLine (ValuesSet(num_1, num_2 ));