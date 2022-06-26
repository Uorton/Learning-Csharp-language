// Задайте массив заполненный случайными положительными
// трехзначными числами. Напишите программу, 
// которая покажет количество четных чисел в массиве.

int[] CreateAndFillArray()
{
    int [] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        
    }
    return array;
}

int [] arr = CreateAndFillArray();

void FindArray(int [] array)
{
    int number = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {    
            number++;
        }
        Console.Write($"{array[i]} ");

    }
    Console.Write("\nКоличество четных чисел: ");
    Console.Write(number);
}

FindArray(arr);
