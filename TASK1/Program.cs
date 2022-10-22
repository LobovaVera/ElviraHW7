/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


void Main()
{
    int row, col;
    ReceiveRowsAndColumns(out row, out col);
    double[,] ourArray = GetDoubleArray(row, col);
    PrintArray(ourArray);

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
            result[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();

    }
}

Main();