Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m < n) WriteEven(m, n);
else WriteEven(n, m);


static void WriteEven(int m, int n)
{
    if ((m & 1) == 0)
    {
        Console.Write(m);
        if (m + 1 < n) Console.Write(", ");
    }
    if (m != n) WriteEven(m + 1, n);
}
