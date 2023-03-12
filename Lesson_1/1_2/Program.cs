// See https://aka.ms/new-console-template for more information

string s_a = Console.ReadLine()!;

if (s_a == "1")
{
    Console.WriteLine("Понедельник");
}
else if (s_a == "2")
{
    Console.WriteLine("Вторник");
}
else if (s_a == "3")
{
    Console.WriteLine("Среда");
}
else if (s_a == "4")
{
    Console.WriteLine("Четверг");
}
else if (s_a == "5")
{
    Console.WriteLine("Пятница");
}
else if (s_a == "6")
{
    Console.WriteLine("Суббота");
}
else if (s_a == "7")
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Ошибка, Введите число от 1 до 7");
}
