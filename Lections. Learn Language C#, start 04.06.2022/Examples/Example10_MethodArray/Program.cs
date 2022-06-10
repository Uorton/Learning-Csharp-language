int[] array = {91, 72, 83, 4, 4, 85, 36, 47, 18};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}