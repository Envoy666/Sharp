Console.WriteLine("Введите первое число:");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int temp = Convert.ToInt32(Console.ReadLine());
if (temp > max) max = temp;

Console.WriteLine("Введите третье число:");
temp = Convert.ToInt32(Console.ReadLine());
if (temp > max) max = temp;

Console.WriteLine("max = " + max);
