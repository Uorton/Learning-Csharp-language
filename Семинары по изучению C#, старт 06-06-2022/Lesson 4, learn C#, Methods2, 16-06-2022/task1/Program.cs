// Напишите программу, которая принимает на вход число (А) и выдает сумму
// чисел от 1 до А.

int Summary (int A)
{
    int result = 0;
    for (int i = 0; i <= A; i++)
    {
        result = result + i;
    }
    return result;
}

Console.WriteLine(Summary(7));
Console.WriteLine(Summary(11));
Console.WriteLine(Summary(8));
Console.WriteLine(Summary(4));