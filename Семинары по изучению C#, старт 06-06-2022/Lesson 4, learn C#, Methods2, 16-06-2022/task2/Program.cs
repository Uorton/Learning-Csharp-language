// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.

//void quantity(string number)
//{
  //  int count = number.Length;
    //System.Console.WriteLine($"Количество цифр = {count}");
//}

//Console.Write("Введите любое число: ");
//string number = Console.ReadLine();
//bool check = Int32.TryParse(number, out int number2);
//if (check == false) System.Console.WriteLine("Ошибка!");
//else
//{
  //  quantity(number);
//}



// Вариант 2.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countnumbers (int N)
{
    int count = 0;
    while (N != 0)
    {
        N = N/10;
        count = count + 1;
    }
    return count;
}
countnumbers(number);
System.Console.WriteLine(countnumbers(number));