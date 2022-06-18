string Palindrom = Convert.ToString(Console.ReadLine());
char[] obrtext = Palindrom.ToCharArray();
Array.Reverse(obrtext);
string finaltext = new string(obrtext);

if (Palindrom == finaltext)
 {
    Console.WriteLine("Данная запись является палиндромом");
 }
if (Palindrom != finaltext)
 {
    Console.WriteLine("Данная запись не является палиндромом");
 }