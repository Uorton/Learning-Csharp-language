// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента,
// или же указание, что такого элемента нет.

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

void FindElementArray(int[,] array, int n, int m)
{
    int element = 0;
    bool isFinding = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == n && j == m) 
            {
                element = array[i,j];
                isFinding = true;
                break;
            }
            
        }
    }
    if (isFinding)
    {
      Console.WriteLine(element);
    }
    else
    {
      Console.WriteLine("Элемент на заданной позиции не найден");
    }
}

int[,] arr = CreateArray(3, 4);
FillArray(arr);
PrintArray(arr);
FindElementArray(arr, 1, 2);
Console.WriteLine();