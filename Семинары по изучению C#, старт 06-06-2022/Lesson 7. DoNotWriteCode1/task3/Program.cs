// Задайте двумерный массив. Найдите элементы, у которых
// оба индекса четные, и замените эти элементы на их квадраты.


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
            array[i,j] = new Random().Next(2, 4);

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

void EvenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
        }
    }
}

int[,] arr = CreateArray(3, 4);
FillArray(arr);
PrintArray(arr);
EvenArray(arr);
Console.WriteLine();
PrintArray(arr);