// Задайте двумерный массив размером m*n, заполненный
// случайными вещественными числами.


double[,] CreateArray(int n, int m)
{
    return new double[n, m];
}

void FillArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            array[i,j] = new Random().NextDouble();
        }
        
    }
}

void PrdoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }

}

double[,] arr = CreateArray(3, 4);
FillArray(arr);
PrdoubleArray(arr);







