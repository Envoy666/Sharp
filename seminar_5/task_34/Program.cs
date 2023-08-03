int[] array = new int[10];
Random rand = new();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
}

int count = 0;

foreach (int i in array)
{
    Console.Write($"{i} ");
    if ((i & 1) == 0) count++;
}
Console.WriteLine();

Console.WriteLine(count);
