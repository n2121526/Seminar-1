Console.WriteLine("Введите первое число: ");
int NumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int NumberB = int.Parse(Console.ReadLine());
if (NumberA > NumberB)
{
    Console.WriteLine($"max = {NumberA}");
}
else
{
        Console.WriteLine($"max = {NumberB}");
}
