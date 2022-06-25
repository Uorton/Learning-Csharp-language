Console.WriteLine("Введите кол-во: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
Console.Write("your array: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");

int imin = 0, imax = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > array[imax]) imax = i;
    if (array[i] < array[imin]) imin = i;
}

Console.WriteLine("min : array[" + imin + "] = " + array[imin]);
Console.WriteLine("max : array[" + imax + "] = " + array[imax]);

int prod = 1, from = Math.Min(imin, imax)+1, to = Math.Max(imin, imax) -1;

for (int i = from; i <= to; i++)
{
    prod *= array[i];
}
Console.WriteLine("prod from " + from + " to " + to + " : " + prod);
