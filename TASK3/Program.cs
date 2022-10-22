/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


void Main()
{
    int row, col;
    ReceiveRowsAndColumns(out row, out col);
    int[,] ourArray = GetArray(row, col);
    PrintArray(ourArray);
    EachRowArithmeticMean(ourArray);

}

void ReceiveRowsAndColumns(out int rows, out int columns)
{
    Console.WriteLine("Введите число строк");
    rows = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число столбцов");
    columns = int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            
            result[i, j] = new Random().Next(-10, 10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
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

void EachRowArithmeticMean(int[,] array)
{    double arithmeticMean = 0;
  
    for(int i = 0; i<array.GetLength(0); i++)
    {
         arithmeticMean = 0;
        for(int j =0; j<array.GetLength(1); j++)
        {
            
            arithmeticMean += Convert.ToDouble(array[i,j]);

        }
        Console.WriteLine($"Среднее арифметическое строки номер {i+1} = {arithmeticMean/(array.GetLength(1))} ");
    }
}
Main();