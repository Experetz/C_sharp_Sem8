﻿/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void FillArray(int[,,] array)
   {
       int number = 10;
       int size1 = array.GetLength(0);
       int size2 = array.GetLength(1);
       int size3 = array.GetLength(2);
       for (int i = 0; i < size1; i++)
       {
           for (int j = 0; j < size2; j++)
           {
               for (int k = 0; k < size3; k++)
               {
                   array[i, j, k] = number++;
               }
           }
       }
   }
void PrintArray(int[,,] array)
   {
       for (int i = 0; i < array.GetLength(0); i++)
       {
           for (int j = 0; j < array.GetLength(1); j++)
           {
               for (int k = 0; k < array.GetLength(2); k++)
               {
                   Console.WriteLine(array[i, j, k] + "(" + i + "," + j + "," + k + ")");
               }
           }
       }
   }

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);
