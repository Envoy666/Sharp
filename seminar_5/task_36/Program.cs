int[] array = new int[10];
Random rand = new();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
}

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    if ((i & 1) != 0) sum += array[i];
}
Console.WriteLine();

Console.WriteLine(sum);
