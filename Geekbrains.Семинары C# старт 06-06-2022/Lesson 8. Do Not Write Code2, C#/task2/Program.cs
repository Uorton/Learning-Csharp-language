// Задайте двумерный массив. Напишите программу, которая зменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

bool ChangeColumsforLines(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Недопустимый переход");
        return false;
    }
    else
    {
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;        
        }
    }
    }
    return true;
}

int[,] arr = CreateArray(4,4);
FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
if(ChangeColumsforLines(arr) == true)
{
    PrintArray(arr);
}