// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbersM = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        numbersM[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] numbersM)
{
    int count = 0;
    for (int i = 0; i < numbersM.Length; i++)
    {
        if(numbersM[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);
Console.WriteLine($"Введено чисел больше 0: {Comparison(numbersM)} ");