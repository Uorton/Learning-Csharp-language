// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

void CoordinateDemo(int part)
{
    if (part < 1 || part > 4)
    {
        Console.WriteLine("Заданы не верные параметры");
    }
    else
    {
        if(part == 1) System.Console.WriteLine("x > 0 и y > 0");
        if(part == 2) System.Console.WriteLine("x < 0 и y > 0");
        if(part == 3) System.Console.WriteLine("x < 0 и y < 0");
        if(part == 4) System.Console.WriteLine("x > 0 и y < 0");
    }
}
CoordinateDemo(1);
CoordinateDemo(4);
CoordinateDemo(2);
CoordinateDemo(3);
CoordinateDemo(8);