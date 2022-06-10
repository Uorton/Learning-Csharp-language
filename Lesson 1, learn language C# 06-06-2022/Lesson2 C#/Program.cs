int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число: {number}");
int result_number = (number / 100) * 10 + (number % 10);
Console.WriteLine($"Результат: {result_number}");
