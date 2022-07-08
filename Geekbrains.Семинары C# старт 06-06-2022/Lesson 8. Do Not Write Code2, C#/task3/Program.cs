// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных.

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

void Shift(int[,] array)
{
    int length = array.GetLength(0)*array.GetLength(1);
    int [] temp = new int [length];
    int result = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[count] = array[i,j];
            count++;
            Console.Write($"{temp[i]}");
            if (array[i,j] == temp[i+1])
            {
                result++;
                Console.WriteLine($"= {result}");
            }
            else
            {
                temp[i] = array[i,j];
            }
        }
    }
    Console.WriteLine($"{temp}");
}

int[,] arr = CreateArray(4,4);
FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
Shift(arr);