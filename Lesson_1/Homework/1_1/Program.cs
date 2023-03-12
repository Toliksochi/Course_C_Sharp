// See https://aka.ms/new-console-template for more information

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a < b)
{
    Console.Write("max = " + b + " ; " + "min = " + a); 
}
else if (a > b)
{
    Console.Write("max = " + a + " ; " + "min = " + b); 
}
else
{
    Console.Write("Числа равны");
} 




