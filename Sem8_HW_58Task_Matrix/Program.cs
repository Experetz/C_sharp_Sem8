/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
  int rows1 = matrix1.GetLength(0);
  int columns1 = matrix1.GetLength(1);
  int rows2 = matrix2.GetLength(0);
  int columns2 = matrix2.GetLength(1);

  if (columns1 != rows2)
        {
            throw new Exception("Uncorrect matrix size");
        }
 int[,] resultMatrix = new int[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return resultMatrix;
}       

void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


 int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
 int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };

 int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
 Console.WriteLine($"The result matrix would be:\n");
 PrintMatrix(resultMatrix);

