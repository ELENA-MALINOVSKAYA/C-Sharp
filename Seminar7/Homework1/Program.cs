// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает индекс этого элемента или 
//же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    
    
    int row = Setnumbers("m");
    int column = Setnumbers("n");
    double[,] matrix = GetRandomMatrix(row,column);
    PrintMatrix(matrix);

    int Setnumbers(string name)
    {   
        string[] arr = name.Split(" ");
        Console.WriteLine($"Enter numbers {name}");
        int num = int.Parse(Console.ReadLine());
        return num;
    }


double[,] GetRandomMatrix(int rows, int columns, int begin=-10, int last=10)
{   
    double[,] matrix = new double[rows,columns];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(begin,last+1) + random.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{ 
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
}

