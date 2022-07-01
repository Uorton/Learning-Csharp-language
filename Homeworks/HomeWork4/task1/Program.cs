// Напишите цикл. который принимает на вход
// 2 числа (А и В) и возводит число А в натуральную
// степень В.

System.Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;

for (int i = 1; i < b; i++)
{
    stepen = stepen * a;
}
System.Console.WriteLine("А в степени В равно: " + stepen);