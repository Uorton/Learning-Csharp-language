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
        Console.WriteLine("Прямые пересекаются");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются");
    }
}
double x = (b2-b1)/(k1-k2);
double y = b1*x+k1;

Console.WriteLine($"Точки пересечения: {x}, {y} ");



//K1*x+d1-y=0. Уравнение прямой отрезка O2 будет иметь вид: K2*x+d2-y=0. 
//Здесь K1=(y12-y11)/(x12-x11), d1=(x12*y11-x11*y12)/(x12-x11),
// K2=(y22-y21)/(x22-x21), d2=(x22*y21-x21*y22)/(x22-x21).