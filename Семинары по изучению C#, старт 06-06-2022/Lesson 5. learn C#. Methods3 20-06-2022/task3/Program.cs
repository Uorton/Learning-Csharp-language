// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10, 99]

int[] CreateArray()
{
    int [] array = new int [123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int [] arr = CreateArray();


void PrintElement(int [] array)
{
    int number = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {            
            number++;       
            Console.Write($"{array[i]}, ");  
        }
        
    }
    Console.Write("\n Количество совпадений: ");
    Console.Write(number);    
}

PrintElement(arr);