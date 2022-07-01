// Напишите программу, которая найдет точку пересечения
// двух прямых, заданных уравнениями:
// y = k1*x+b1, y=k2*x+b2. Значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
   
}
else
    {
        Console.WriteLine("Прямые пересекаются");

double x = (b2-b1)/(k1-k2);
double y = b1*x+k1;
Console.WriteLine($"Точки пересечения: {x}, {y} ");

    }


