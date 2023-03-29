/* Напишите программу, которая будет
преобразовывать десятичное число в двоичное. */

string Convert(int num_1)
{
    string A = "";
    while (num_1 > 0)
    {
        A = num_1 % 2 + A;
        num_1 = num_1 / 2;
    }
    return A;
}
Console.WriteLine (Convert(12));