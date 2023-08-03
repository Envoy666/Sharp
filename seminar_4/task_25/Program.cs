Console.WriteLine("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень:");
int numB = Convert.ToInt32(Console.ReadLine());

double prod = 1;

if (numB > 0)
{
    for (int i = 0; i < numB; i++)
    {
        prod *= numA;
    }
}
else if (numB < 0)
{
    for (int i = 0; i > numB; i--)
    {
        prod /= numA;
    }
}

Console.WriteLine(prod);
