Console.WriteLine("Введите длинну: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 1;
while (res < n)
{
    if (res == 1)
    {
        res += 1;
    }
    System.Console.WriteLine(res);
    res += 2;
}


