// Перебор слов.

char[] s = { 'a', 'i', 'c', 'v'};
int count = s.Length;
int n = 1;
for (int a = 0; a < count; a++)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{n++, -2}{s[a]}{s[i]}");
    }
    
}

// Нужно придумать, как написать всевозможные слова Т букв, если Т неизвестно.