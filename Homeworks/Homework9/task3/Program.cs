// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int FunctionAkkerman(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else 
    {
        if ((m != 0) && (n == 0))
        {
            return FunctionAkkerman(m - 1, 1);
        }
        else
        {
            return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
        }
    }
}

int result = FunctionAkkerman(3, 3);
System.Console.WriteLine(result);