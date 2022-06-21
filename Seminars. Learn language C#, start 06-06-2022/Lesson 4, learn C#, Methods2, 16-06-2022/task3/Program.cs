// Напишите программу, которая принимает на вход число (N) 
// и выдает произведение чисел от 1 до N.

int Composition (int N)
{
    int result = 1;
    if (N > 0)
    {
    for (int i = 1; i <= N; i++)
    {
        result = result * i;
    }
    return result;
    }
    else
    {
        System.Console.WriteLine("0");
    } 
}

Console.WriteLine(Composition(5));
Console.WriteLine(Composition(4));