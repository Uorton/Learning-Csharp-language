// Задайте двумерный массив. Найдите сумму элементов, находящихся на
// главной диагонали (с индексами (0;0); (1;1)) и т.д.


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
            array[i,j] = new Random().Next(1, 10);
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

void SumDiagonalArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {sum = sum+array[i,j];}
        }
        
    }
    Console.WriteLine($"Сумма элементов, находящихся на главной диагонали: {sum}");
}

int[,] arr = CreateArray(3, 4);
FillArray(arr);
PrintArray(arr);
SumDiagonalArray(arr);








