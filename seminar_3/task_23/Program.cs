Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;
while (current <= number)
{
    Console.Write(Math.Pow(current, 3));
    if (current != number) Console.Write(", ");
    current++;
}
