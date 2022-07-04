// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X =/ 0 и Y =/ 0, и
// выдает номер четверти плоскости, в которой находится эта точка.


void SearchCoordinates(int X, int Y)
{
    if (X == 0 || Y == 0)
    {
        Console.WriteLine("Некорректные данные");
    }
    else
    {
        if(X > 0 && Y > 0)
        {
            System.Console.WriteLine("1");
        }
        if(X > 0 && Y <0)
        {
            System.Console.WriteLine("4");
        }
        if(X < 0 && Y > 0)
        {
            System.Console.WriteLine("2");
        }
        if(X < 0 && Y < 0)
        {
            System.Console.WriteLine("3");
        }
    }
}
SearchCoordinates(1, 3);
SearchCoordinates(-1, 3);
SearchCoordinates(1, -3);
SearchCoordinates(-1, -3);
SearchCoordinates(0, 0);