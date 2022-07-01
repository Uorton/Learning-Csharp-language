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

void FindArray(int[,] array)
{
    int element;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            element = array[i,j];
            if (element == i && element == j)
            {
                Console.WriteLine("Такого элемента нет");                
            }
            else
            {
                Console.WriteLine($"Позиция элемента в двумерном массиве: {element}");
            }
            break;
        }
        Console.WriteLine();
    }
}

int[,] arr = CreateArray(3, 4);
FillArray(arr);
PrintArray(arr);
FindArray(arr);
Console.WriteLine();



