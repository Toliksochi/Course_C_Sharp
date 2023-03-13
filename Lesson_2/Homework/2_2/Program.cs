
int Takenum(int num)
{
   Console.WriteLine (num);
   return num/100*10+num%10; 
}

int result = Takenum(new Random().Next(100 , 1000));

Console.WriteLine (result);