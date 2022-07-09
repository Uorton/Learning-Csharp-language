// Задайте значения М и N. Напишите программу, которая
// найдет сумму натуральных элементов в промежутке от M до N.

int SumRecursive(int number)
{
    int sum = 0;
    if (number != 0)
    {
        sum += SumRecursive(number/10)+ number%10;
    }
    return sum;
}
System.Console.WriteLine(SumRecursive(1357));