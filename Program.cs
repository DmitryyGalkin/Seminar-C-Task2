Console.Clear();

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int number2 =  int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.Write($"max = {number1}, min = {number2}");
}
else
{
    Console.Write($"max = {number2}, min = {number1}");
}