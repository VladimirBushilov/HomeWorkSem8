// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void ColumnsMeanValue(int[,] matrix)
{
    double columnsum = 0;
    System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnsum = columnsum + matrix[i, j];
        }
        System.Console.Write($"{Math.Round(columnsum / matrix.GetLength(1), 1)}" + "; ");
        columnsum = 0;
    }

}

int[,] matrix = FillMatrix(6, 6, 0, 20);
System.Console.WriteLine();
PrintMatrix(matrix);
// System.Console.WriteLine();
ColumnsMeanValue(matrix);