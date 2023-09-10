Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int even = 2;

while (a >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}