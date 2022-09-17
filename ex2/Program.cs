Console.Clear();
Console.WriteLine("enter first nimber");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second nimber");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter third nimber");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.Write("maximum is ");
    Console.Write(a);
    Console.WriteLine();
}
else
if (b > a && b > c)
{
    Console.Write("maximum is ");
    Console.Write(b);
    Console.WriteLine();
}
else
{
    Console.Write("maximum is ");
    Console.Write(c);
    Console.WriteLine();
}
