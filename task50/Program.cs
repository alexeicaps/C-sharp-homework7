// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату строки массива: ");
int coordrow = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату колонки массива: ");
int coordcolumn = int.Parse(Console.ReadLine()!);
int[,] array = GetArray2(rows, columns);
GetNumber(array, coordrow, coordcolumn);


int[,] GetArray2(int row, int column)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(0, 100);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

void GetNumber(int[,] arr, int coordrow, int coordcolumn)
{
    if (coordrow > arr.GetLength(0) || coordcolumn > arr.GetLength(1)) 
    {
        Console.Write($"{coordrow}{coordcolumn} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(array[coordrow, coordcolumn]);
    }
}