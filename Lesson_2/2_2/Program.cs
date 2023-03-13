
void Takenum (int num1, int num2)
{
    if (num1 % num2 == 0)
        Console.WriteLine ("кратно");
    else 
        Console.WriteLine ($"не кратно {num1 % num2}");
          
}
Takenum (16, 4);