// a = 5; b = 7 -> max = 7;
// a = 2 b = 10 -> max = 10;
// a = -9 b = -3 -> max = -3;

using System.ComponentModel.DataAnnotations;

int a = -9;
int b = -3;

if (a > b)
{
    Console.Write ("Max = ");
    Console.WriteLine (a);
}
else 
{
    Console.Write ("Max = ");
    Console.WriteLine (b);
}