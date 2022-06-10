int a = 5;
int b = 7;
int max = a;
int min = b;

if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;

System.Console.Write("max = ");
System.Console.WriteLine(max);
System.Console.Write("min = ");
System.Console.WriteLine(min);