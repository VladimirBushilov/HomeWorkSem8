// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] spiralArray = new int[4, 4];
int value = 1;
int rowStart = 0;
int rowEnd = 3;
int colStart = 0;
int colEnd = 3;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    for (int i = colStart; i <= colEnd; i++)
    {
        spiralArray[rowStart, i] = value++;
    }
    rowStart++;

    for (int i = rowStart; i <= rowEnd; i++)
    {
        spiralArray[i, colEnd] = value++;
    }
    colEnd--;

    if (rowStart <= rowEnd)
    {
        for (int i = colEnd; i >= colStart; i--)
        {
            spiralArray[rowEnd, i] = value++;
        }
        rowEnd--;
    }

    if (colStart <= colEnd)
    {
        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiralArray[i, colStart] = value++;
        }
        colStart++;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(spiralArray);