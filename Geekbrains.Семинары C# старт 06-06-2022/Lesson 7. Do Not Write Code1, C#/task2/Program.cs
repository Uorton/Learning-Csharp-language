// Задайте двумерный массив размера m на n. Каждый элемент в массиве
// находится по формуле: A(mn) = m+n.
// Выведите полученный массив на экран.


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
            array[i, j] = i+j;   
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

int[,] arr = CreateArray(3, 4);

FillArray(arr);
PrintArray(arr);


