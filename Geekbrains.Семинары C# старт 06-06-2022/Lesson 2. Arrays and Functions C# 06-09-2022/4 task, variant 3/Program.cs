System.Console.WriteLine("Введите число numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (Math.Pow(numberA, 2) == numberB || numberA == Math.Pow(numberB, 2))
{
    System.Console.WriteLine("Одно число является квадратом другого числа");
}
else
{
    System.Console.WriteLine("Одно число не является квадратом другого числа");
}