// Задайте двумерный массив. Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

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

void ChangeMaxMinLines(int[,] array)
{
    int tempElement = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempElement = array[0,j];
            array[0,j] = array[array.GetLength(0)-1, j];
            array[array.GetLength(0)-1,j] = tempElement;
        }
}
        



int[,] arr = CreateArray(3, 4);
FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
ChangeMaxMinLines(arr);
PrintArray(arr);