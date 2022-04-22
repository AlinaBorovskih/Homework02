Console.WriteLine("Введите цифру от 1 до 7");
int day = int.Parse(Console.ReadLine());

if (day >= 6)
{
    Console.WriteLine("Этот день выходной");
} 
else if (day <= 5)
{
    Console.WriteLine("Этот день не выходной");
} 