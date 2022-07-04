// Задайте двумерный массив. Напишите программу, которая
// поменяет местами первую и последнюю строку массива.



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(1,10);
        
        }
    }
}

void ChangeFirstLastArray(int[,] array)
{
    int tempElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempElement = array[0, j];
            array[0, j] = array[array.GetLength(0)-1];
            array[array.GetLength(0)-1, j] = tempElement;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0)-1; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    }
}

int[,] arr = CreateArray(3,4);
FillArray(arr);
PrintArray(arr);
ChangeFirstLastArray(arr);
PrintArray(arr);






// Как указывать двумерные массивы?:
// string[,] table = new string [2, 3]; - это пример.

// Прямоугольная таблица чисел(в математике называется матрица):
//                      строки столбцы
// int[,] matrix = new int [5, 8];

//string [,] table = new string [2, 5];
// String.Empty
// table [0,0]      table [0,1]     table[0,2] .... table [0,4]
// table [1,0]      table [1,1]     table[1,2] .... table [1,4]
//table[1, 2] = "слово";

//for (int rows = 0; rows < 2; rows++)
//{
 //   for (int columns = 0; columns < 5; columns ++)
 //   {
       // Console.WriteLine($"-{table[rows, columns]}-");
 //   }
//}




//void PrintArray(int[,] matr)
//{
  //  for (int i = 0; i < matr.GetLength(0); i++)
    //{
      //  for (int j = 0; j < matr.GetLength(1); j++)
        //{
        //Console.Write($"{matr[i, j]} ");
        //}
    //Console.WriteLine();
   // }
//}

//void FillArray(int[,] matr)
//{
   // for (int i = 0; i < matr.GetLength(0); i++)
   // {
     //   for (int j = 0; j < matr.GetLength(1); j++)
       // {
           // matr [i, j] = new Random().Next(1,10); // [1; 10]
        //}
    //}
//}

//int[,] matrix = new int [3, 4];
//PrintArray(matrix);
//FillArray(matrix);
//Console.WriteLine();
//PrintArray(matrix);







//int[,] pic = new int[,]
//{
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
//{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//};

//void PrintImage(int[,] image)
//{
   // for (int i = 0; i < image.GetLength(0); i++)
   // {
       // for (int j = 0; j < image.GetLength(1); j++)
       // {
            //Console.WriteLine($"{image[i, j]} ");
          //  if (image[i,j] == 0) Console.Write($" ");
        //    else Console.Write($"+");
    //    }
      //  Console.WriteLine();
  //  }
//}


//void FillImage(int row, int col)
//{
   // if(pic[row, col] == 0)
   // {
      //  pic[row, col] = 1;
     //   FillImage(row-1, col);
        //FillImage(row, col-1);
      //  FillImage(row+1, col);
    //    FillImage(row, col+1);
  //  }
//}

//PrintImage(pic);
//FillImage(13, 13);
//PrintImage(pic);







