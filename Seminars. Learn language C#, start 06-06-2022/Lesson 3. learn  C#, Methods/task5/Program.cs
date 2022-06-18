Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Method(int N)
{
    for(int i = 0; i <= N; i++)
    {
        int kvadrat = i*i;
        Console.WriteLine($"{kvadrat}");
    }
}
Method(number);