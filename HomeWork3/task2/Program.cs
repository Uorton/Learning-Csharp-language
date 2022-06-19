// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// Вариант А - A(3,6,8); B(2,1, -7) -> 15,84


void Distance (int x, int y, int z, int x1, int y1, int z1)
{
    int d = ((x1-x)*(x1-x)+(y1-y)*(y1-y)+(z1-z)*(z1-z));
    double sqr = Math.Sqrt(d);
    double sqr1 = Math.Round(sqr, 2);
    Console.WriteLine(sqr1);
}
Distance(3, 6, 8, 2, 1, -7);