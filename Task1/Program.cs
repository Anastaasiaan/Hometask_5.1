// a = 5; b = 7 -> max = 7;
// a = 2 b = 10 -> max = 10;
// a = -9 b = -3 -> max = -3;

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

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