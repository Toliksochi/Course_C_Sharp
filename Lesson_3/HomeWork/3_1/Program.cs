//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palin (int x)
{
    if (x < 10000 || x >=100000)
    {
        Console.WriteLine ("Вы ввели не пятизначное число. Попробуйте еще раз");
    }
    else
        {
            string i = x.ToString();
            if (i[0] == i[4] && i[1] == i[3])
            {
                Console.WriteLine ("Число является палиндромом");
            }
            else
            {
                Console.WriteLine ("Число не является палиндромом");
            }
        }           
}
Console.WriteLine ("Введите пятизначное число");
int num = int.Parse (Console.ReadLine ()!);
Palin (num);