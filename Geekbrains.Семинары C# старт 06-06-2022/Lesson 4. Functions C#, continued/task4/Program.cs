// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке [1,0,1,1,0,1,0,0]

void FillArray(int [] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}

int[] array = new int [8];
FillArray(array);
PrintArray(array);