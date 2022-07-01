int[] CreateArray()
{
    int [] array = new int [15];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 30);
    }
    return array;
}

int [] arr = CreateArray();


void PrintElement(int [] array)
{
    int number = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 30)
        {            
            number++;       
            Console.Write($"{array[i]}, ");  
        }
        
    }
    Console.Write("\n Количество совпадений: ");
    Console.Write(number);    
}

PrintElement(arr);