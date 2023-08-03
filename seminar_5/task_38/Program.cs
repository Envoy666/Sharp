double[] array = new double[10];
Random rand = new();

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.NextDouble() * 10, 2);
}

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    if (array[i] < min) min = array[i];
    else if (array[i] > max) max = array[i];
}
Console.WriteLine();

Console.WriteLine($"min = {min}");
Console.WriteLine($"max = {max}");
Console.WriteLine($"diff = {max - min}");
