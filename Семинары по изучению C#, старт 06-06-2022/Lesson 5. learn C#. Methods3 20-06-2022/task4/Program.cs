// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний, и т.д.
// Результат запишите в новом массиве.

int[] CreateArray()
{
    int[] array = new int[11];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]}, ");
    }
    return array;
}
int [] arr = CreateArray();

int[] CreateSumArrayElements(int[] array)
{
    int[] number = new int [5];
    int length = array.Length;

    for (int i = 0; i < array.Length / 2; i++)
    {
        number[i] = array[i] * (array[length - 1]);
        length = length - 1;
    }
    return number;
}

int[] number = CreateSumArrayElements(arr);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

Console.WriteLine();
PrintArray(number);

