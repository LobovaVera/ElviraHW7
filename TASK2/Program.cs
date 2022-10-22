/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

[1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)*/


void Main()
{
    int row, col;
    ReceiveRowsAndColumns(out row, out col);
    double[,] ourArray = GetDoubleArray(row, col);
    PrintArray(ourArray);
    int rowIndex, columnIndex;
    GetIndexesFor(out rowIndex, out columnIndex);
    FindTheNumberByIndexes(rowIndex, columnIndex, ourArray);
}

void ReceiveRowsAndColumns(out int rows, out int columns)
{
    Console.WriteLine("Введите число строк");
    rows = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число столбцов");
    columns = int.Parse(Console.ReadLine()!);
}

double[,] GetDoubleArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();

    }
}

void GetIndexesFor(out int rowIndex, out int columnIndex)
{
    Console.WriteLine("Введите номер строки");
    rowIndex = int.Parse(Console.ReadLine()!) - 1;

    Console.WriteLine("Введите номер столбца");
    columnIndex = int.Parse(Console.ReadLine()!) - 1;
}

void FindTheNumberByIndexes(int rowNumber, int columnNumber, double[,] array)
{
    if (rowNumber < array.GetLength(0) && columnNumber < array.GetLength(1))
    {
        Console.WriteLine($"Ваше чило =  {array[rowNumber, columnNumber]} ");
    }
    else
    {
        Console.WriteLine("К сожалению, в нашем массиве нет такой позиции");
    }

}

Main();