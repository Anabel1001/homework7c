// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] FillMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3} ]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(3, 4);
PrintMatrix(matrix);

System.Console.WriteLine("Введите номер строки:");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
System.Console.WriteLine("Введите номер столбца:");
int col = Convert.ToInt32(Console.ReadLine()) - 1;

if (row < 0 | row > matrix.GetLength(0) - 1 | col < 0 | col > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine($"Значение элемента массива -> {matrix[row, col]}");
}