// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();

    }
}

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int [,] MatrixMultiplied = new int [matrix1.GetLength(0),matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix1.GetLength(1); k++) 
            {
               MatrixMultiplied[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
return MatrixMultiplied;
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int row1 = ReadInt("Введите количество строк матрицы 1");
int col1 = ReadInt("Введите количество столбцов матрицы 1");
int row2 = ReadInt("Введите количество строк матрицы 2");
int col2 = ReadInt("Введите количество столбцов матрицы 2");

if (col1 == row2)
{
    int[,] matrix1 = FillMatrix(row1, col1, 0, 10);
    int[,] matrix2 = FillMatrix(row2, col2, 0, 10);

    System.Console.WriteLine();
    PrintMatrix(matrix1);
    System.Console.WriteLine();
    PrintMatrix(matrix2);
    System.Console.WriteLine();
    PrintMatrix(MatrixMultiply(matrix1, matrix2));
}
else
{
    System.Console.WriteLine("Для умножения матриц количество столбцов матрицы 1 должно быть равно количеству строк матрицы 2");
}