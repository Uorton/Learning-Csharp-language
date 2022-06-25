// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний, и т.д.
// Результат запишите в новом массиве.

void CompositionOfPairds(int[] array)
{
    int[] result = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < result.Length; i++)
    {
        if (array.Length % 2 == 0)
        {
            result = new int[array.Length / 2];
            result[i] = array[i] * array[array.length - i - 1];
        }
        else
        {
            result = new int[array.Length / 2 + 1];
        }
        
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[array.Length / 2];
        }
        Console.WriteLine(result);
    }
}