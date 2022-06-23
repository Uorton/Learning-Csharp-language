// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.

int[] array = CreateFillArray();
PrintArray(array);
ConvertArray(array);
PrintArray(array);

int[] CreateFillArray()
{
    Console.WriteLine("Введите кол-во элементов массива: ");
    int ArraySize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(ArraySize);
    int[] array = new int[ArraySize];
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}

int[] ConvertArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = array[i]*(-1);
    }
    return array;
}