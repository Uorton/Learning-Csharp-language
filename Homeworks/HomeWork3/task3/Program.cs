// Напишите программу, которая принимает на вход число (N) и выдает таблицу
// кубов чисел от 1 до N. --- 3 -> 1, 4, 9.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Method(int N)
{
    for(int i = 0; i <= N; i++)
    {
        int cube = i*i*i;
        Console.WriteLine($"{cube}");
    }
}
Method(number);