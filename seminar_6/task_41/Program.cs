Console.WriteLine("Введите количество чисел:");
int common = Convert.ToInt32(Console.ReadLine());
int positive = 0;

Console.WriteLine("Введите числа:");
while (common > 0)
{
    if (Convert.ToInt32(Console.ReadLine()) > 0) positive++;
    common--;
}
Console.WriteLine();
Console.WriteLine(positive);
