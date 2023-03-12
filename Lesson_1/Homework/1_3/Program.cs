// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
   Console.WriteLine("Число А  - четное"); 
}
else
{
    Console.WriteLine("Число А  - нечетное"); 
}