// Задайте массив из 12 элементов, заполненный
// Случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например: в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateAndFillArray()
{
    int [] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        
    }
    return array;
}

int [] arr = CreateAndFillArray();

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
ShowArray(arr);

void SumplusandMinus(int[] arr)
{
    int MaxSum = 0;
    int MinSum = 0;
    for(int i = 0; i < arr.Length; i++)
    {

        if (arr[i] >= 0)
        {
            MaxSum = MaxSum + arr[i];
        } 
        else
        {
            MinSum = MinSum + arr[i];
        }
    }
    Console.WriteLine($"{MinSum} {MaxSum}");
}
SumplusandMinus(arr);