// Задайте значения М и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.


int NatureNumber(int M, int N)
{
    if (M <= N)
    {
         System.Console.WriteLine(M);
         NatureNumber(M + 1, N);
    }
    return M;
}
NatureNumber(1, 5);