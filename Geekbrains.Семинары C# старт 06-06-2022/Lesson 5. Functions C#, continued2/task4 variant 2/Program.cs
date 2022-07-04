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

void compositionOfPairs(int[] array) 
{
    int[] result;

    if ( array.Length % 2 == 0)
    {
        result = new int[array.Length / 2];
        for (int i = 0; i < result.Length; i++)
        { 
            result[i] = array[i] * array[array.Length - i -1];
        }
    } else { 
        result = new int[array.Length / 2 + 1];

        for (int i = 0; i < result.Length; i++) 
        {
            result[i] = array[i] * array[array.Length - i -1];
            
        }

        result[result.Length - 1] = array[array.Length/2]; 

    } 

for (int i = 0; i < result.Length; i++) 
        {
    Console.Write($"{result[i]}, ");
        }
}
Console.WriteLine();
compositionOfPairs(arr);