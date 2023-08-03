Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение чисел:");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение чисел:");
int max = Convert.ToInt32(Console.ReadLine()) + 1;

Random rand = new();
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(min, max);
}

Console.WriteLine("[{0}]", string.Join(", ", array));
