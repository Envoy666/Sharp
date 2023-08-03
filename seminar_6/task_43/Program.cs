double k1 = GetCoef("k1");
double b1 = GetCoef("b1");
double k2 = GetCoef("k2");
double b2 = GetCoef("b2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения: ({x}; {y})");

static double GetCoef(string name)
{
    Console.WriteLine($"Введите коэффициент {name}");
    return Convert.ToDouble(Console.ReadLine());
}
