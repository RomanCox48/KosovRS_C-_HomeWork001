Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int max;

if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}

Console.WriteLine($"max = {max}");