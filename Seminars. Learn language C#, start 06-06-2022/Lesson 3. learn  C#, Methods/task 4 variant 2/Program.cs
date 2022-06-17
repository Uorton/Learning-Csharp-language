// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// Вариант Б - A(7, -5); B(1, -1) -> 7,21


void Distance1 (int x, int y, int x1, int y1)
{
    int d = ((x1-x)*(x1-x)+(y1-y)*(y1-y));
    double sqr = Math.Sqrt(d);
    double sqr1 = Math.Round(sqr, 2);
    Console.WriteLine(sqr1);
}
Distance1(7, -5, 1, -1);