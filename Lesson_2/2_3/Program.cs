void Takenum (int num1)
{
    if (num1 % 7 == 0 && num1% 23 == 0)
        Console.WriteLine ("да");
        
    else       
        Console.WriteLine ("нет");
}
Takenum (int.Parse (Console.ReadLine()));