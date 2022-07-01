// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник со сторонами
// такой длинны.

Console.WriteLine("Проверим, может ли введенные вами числа быть сторонами треугольника");

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
Console.WriteLine("Введенные вами цифры могут быть сторонами треугольника");
else
{
    Console.WriteLine("Введенные вами цифры не могут быть сторонами треугольника");
}
