// Вид 1
void Method1()
{
    Console.WriteLine("Author Kirill Badyuk");
}
//Method1();


// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Text message");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Text", count: 4);
//Method21(count: 4, msg: "new message");


//Вид 3 - Чтото возвращает, но ничего не принимает.

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);


//Вид 4 - чтото принимают, и что-то возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
