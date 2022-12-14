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
double sum = 0;
double res = 0;
for(int i = 0; i < column; i++) 
    {
        sum = 0;
        for(int j = 0; j < row; j++) 
        {
            sum = sum + matrix[j,i];
            res = sum / row;
        }
        Console.WriteLine("Сумма:" + sum + " Среднее: " + res);

    }
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.