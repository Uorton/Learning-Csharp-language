Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result1 = number1 % number2;
int result2 = number1 % number3;

if(result1 == 0)
{
    Console.WriteLine($"{number1} кратно {number2}");
}
else
{
    Console.WriteLine(number1 + " не кратно " + number2 +", остаток " + result1);
}
if(result2 == 0)
{
    Console.WriteLine($"{number1} кратно {number3}");
}
else
{
    Console.WriteLine(number1 + " не кратно " + number3 +", остаток " + result2);
}
