// Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем, и т.д.)

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(1,10);
    }
    return array;
}


int[] ChangeArray(int[] array)
{
       int[] number = new int [array.Length];
       int length = array.Length;
        
        for (int i = 0; i < array.Length; i++)
        {
            number[i] = array[length-1];
            length = length - 1;
        }
        return number;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите длину массива: ");
int LengthArray = Convert.ToInt32(Console.ReadLine());
int [] arr = CreateArray(LengthArray);
int [] number = ChangeArray(arr);
ShowArray(arr);
Console.WriteLine();
ShowArray(number);

