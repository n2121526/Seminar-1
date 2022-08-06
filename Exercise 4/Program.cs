Console.WriteLine("Введите первое число: ");
int NumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int NumberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int NumberC = int.Parse(Console.ReadLine());

int max = NumberA;

if (NumberA > max) max = NumberA;
if (NumberB > max) max = NumberB;
if (NumberC > max) max = NumberC;

Console.Write("max = ");
Console.WriteLine(max);

