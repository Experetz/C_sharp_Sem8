/*  Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

//Method for filling spiral array
void FillSpiralArray(int[,] array, int n)
    {
        int rowStart = 0;
        int rowEnd = n - 1;
               
        int columnStart = 0; 
        int columnEnd = n - 1; 

         int count = 1; 
    
        while (count <= n * n)
        {
            for (int i = columnStart; i <= columnEnd; i++)
            {
                array[rowStart, i] = count++;
            }
            rowStart++;
    
                        for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, columnEnd] = count++;
            }
            columnEnd--;
    
            for (int i = columnEnd; i >= columnStart; i--)
            {
                array[rowEnd, i] = count++;
            }
            rowEnd--;
    
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, columnStart] = count++;
            }
            columnStart++;
        }
    }

void PrintSpiralArray(int [,] array, int n)
{
     for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
        Console.WriteLine(); 
        }   
}        

//Creating array 
 int n = 5;
 int[,] array = new int[n, n];
  FillSpiralArray(array, n);
Console.WriteLine("\nEnjoy your spiral array!\n");  
PrintSpiralArray(array, n);