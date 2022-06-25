// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

int[] CreateArray()
{
    int[] array = new int [5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 20);

    }
    return array;
}

int [] arr = CreateArray();

void FindNoEvenArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += array[i];
        }
    Console.Write($"{array[i]}, ");

    }
    Console.WriteLine("Сумма элементов на нечетных позициях: ");
    Console.Write(sum);
}
FindNoEvenArray(arr);