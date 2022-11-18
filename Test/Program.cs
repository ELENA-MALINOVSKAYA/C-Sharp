﻿Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает индекс этого элемента или же указание, что такого элемента нет");
        Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

        int numTask = Setnumbers("task");

        switch (numTask)
        {
            case 0: return; break;
            case 47:
                int row = Setnumbers("m");
                int column = Setnumbers("n");
                double[,] matrix = GetRandomMatrixToDouble(row, column);
                PrintMatrixToDouble(matrix);
                break;
            case 50:
                int num1 = Setnumbers("number");
                int[,] matrix1 = GetRandomMatrix();
                PrintMatrix(matrix1);
                FindIndex(num1, matrix1);
                break;
            case 52:
                int row2 = Setnumbers("m");
                int column2 = Setnumbers("n");
                int[,] matrix2 = GetRandomMatrix(row2, column2);
                PrintMatrix(matrix2);
                float[] average = FindAverageEachColumn(matrix2);
                PrintArray1(average);
                break;
            case 54:
                int row3 = Setnumbers("m");
                int column3 = Setnumbers("n");
                int[,] matrix3 = GetRandomMatrix(row3, column3);
                PrintMatrix(matrix3);
                int[,] matrixDes = OrderedInDescending(matrix3);
                PrintMatrix(matrixDes);
                break;


            default:
                Console.WriteLine("error");
                break;
        }



    }
}

int Setnumbers(string name)
{
    string[] arr = name.Split(" ");
    Console.WriteLine($"Enter numbers {name}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] GetRandomMatrixToDouble(int rows, int columns, int begin = -10, int last = 10)
{
    double[,] matrix = new double[rows, columns];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(begin, last + 1) + random.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrixToDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetRandomMatrix(int rows = 5, int columns = 5, int begin = 0, int last = 25)
{
    int[,] matrix = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(begin, last + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintSearchNumber(int num, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {
                System.Console.WriteLine($"i={i},j={j}");
                return;
            }

        }

    }
}

bool SearchNumber(int num, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {
                return true;
            }
        }
    }
    return false;
}

float[] FindAverageEachColumn(int[,] matrix)
{
    float[] avg = new float[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        float sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        avg[i] = sum / matrix.GetLength(0);
    }
    return avg;
}

void PrintArray1(float[] arr)
{
    System.Console.Write($"[{String.Join("| ", arr)}]");
}

void FindIndex(int num, int[,] matrix)
{
    if (SearchNumber(num, matrix))
    {
        PrintSearchNumber(num, matrix);
    }
    else
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
}


int[,] OrderedInDescending(int[,] matrix)
{   int max = MaxPosition(matrix);
    int temp = 0;
    // int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

                if (matrix[i,j]<max) 
                {
                temp = matrix[i,j];
                matrix[i,j] = max;
                max = temp;
                }
        }
    }
    return matrix;
}

int MaxPosition(int[,] matrix)
{   
    int max = i;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {   
            if (matrix[i, j+1] > matrix[max])
            {
                matrix[max] = matrix[i, j+1];
            }

        }
    }
    return max;
}
 