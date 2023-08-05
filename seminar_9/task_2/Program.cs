Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m < n) Console.WriteLine(NaturalSum(m, n));
else Console.WriteLine(NaturalSum(n, m));


static int NaturalSum(int m, int n)
{
    // с учетом возможного ввода отрицательных значений
    if (m == n) return m < 0 ? 0 : m;
    return (m < 0 ? 0 : m) + NaturalSum(m + 1, n);
}
