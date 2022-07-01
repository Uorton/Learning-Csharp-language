// Напишите программу, которая принимает
// на вход число и выдавет сумму цифр в числе.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    int num = number % 10;
    number = number / 10;
    sum = sum + num;
}
System.Console.WriteLine("сумма всех цифр в числе равна: " + sum);