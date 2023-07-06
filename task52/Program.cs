// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetFillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = randomElement.Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine("]");
        Console.WriteLine();
    }
}

void FindAverage(int[,] matrix)
{
    double average = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i, j];
        }
        average = Math.Round(average / matrix.GetLength(0), 1, MidpointRounding.ToZero);
        Console.Write($"{average}; ");
        average = 0;
    }
}


int[,] randomMatrix = GetFillMatrix(3, 4);
PrintMatrix(randomMatrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
FindAverage(randomMatrix);

