// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray(int n, int m)
{
    return new int[n, m];
}

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            array[i,j] = new Random().Next(5, 10);
        }
    }
}

void PrintArray(int[,] array)
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

void SumAverageArray(int[,] array)
{
    double avgcolsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            avgcolsum += (double) array[j,i] / array.GetLength(0);
        }
        System.Console.WriteLine($"{avgcolsum}");
        avgcolsum = 0;
    }   

}

int[,] arr = CreateArray(3, 4);
FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
SumAverageArray(arr);