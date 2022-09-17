// смотреть уроки на ютубе по вводу массива вручную с клавиатуры очень весело!
Console.Clear();
Console.Write("massive elements count is ten BECAUSE OF");
int[] ar = new int[10];
for (int i = 0; i < 10; i = i + 1)
{
    Console.Write($"\nenter massive element with {i} index:\t");
    ar[i] = Convert.ToInt32(Console.ReadLine());
    if (ar[i] < 0 || ar[i] > 100 || ar[0] == 0 || ar[1] == 0)
    {
        ar[i] = 1;
        Console.WriteLine("error.");
    }
}
int max = ar;

Console.WriteLine(ar[i]);