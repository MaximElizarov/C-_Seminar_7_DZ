void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
int[,] matrix = new int[row, column];
InputMatrix(matrix);
Console.Write("Ведите позицию массива: ");
string[] pos = Console.ReadLine().Split(" ");
int a = int.Parse(pos[0]);
int b = int.Parse(pos[1]);

if(a < row && b < column)
{
    Console.Write("Такая позиция в массиве есть: " + matrix[a, b]);
}
else
{
    Console.Write("Такой позиции в массиве нет");
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такой позиции в массиве нет