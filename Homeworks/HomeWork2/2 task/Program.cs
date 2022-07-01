Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра - " + numberText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}