// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] - нет
// -3; массив [6, 7, 19, 345, 3] - да

int[] CreateArray()
{
    int [] array = new int [5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int[] arr = CreateArray();

void ToFind(int[] array)
{
    Console.Write("Введите число, которое нужно искать: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int length = array.Length;
    int check = 0;
    int i = 0;
    while (i < length)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"Число {number} найдено в массиве");
            check = 1;
            break;
        }
        else
        {
            i = i + 1;
        }
    }
    if (check == 0)
    {
        Console.WriteLine($"Число {number} не найдено в массиве");
    }
}

ToFind(arr);