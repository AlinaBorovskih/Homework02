Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 1000)
{
    number = number / 100 % 10;
Console.WriteLine($"Вывести третью цифру числа {number} ");
}
else if (number < 100)
{
    Console.WriteLine($"Третьей цифры заданного числа нет ");
}
 else if (number < 1000)
{
    number = number % 10;
    Console.WriteLine($"Вывести третью цифру числа {number} ");
}  