/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


int FindMinSumRow(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    int minSum = int.MaxValue;
    int rowWithMinSum = -1;
    
    for (int i = 0; i < rows; i++)
    {
        int sum = 0; 
         for (int j = 0; j < columns; j++)
         {
            sum+= array[i,j];
         }
         if(sum<minSum) 
         {
            minSum = sum;
            rowWithMinSum = i;
         }   
    }
    return rowWithMinSum;
}


int[,] array = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3,}, {8, 4, 2, 4}, {5, 2, 6, 7}};
Console.WriteLine("\n Your array is  \n");
PrintArray(array);
int rowWithMinSum = FindMinSumRow(array);
Console.WriteLine($"Row with the minimum elements sum is: {rowWithMinSum+1}");
