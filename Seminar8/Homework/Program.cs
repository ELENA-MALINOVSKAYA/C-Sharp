Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine("Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine("Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");



        int numTask = Setnumbers("task");

        switch (numTask)
        {
            case 0: return; break;
            case 54:
                int row3 = Setnumbers("m");
                int column3 = Setnumbers("n");
                int[,] matrix3 = GetRandomMatrix(row3, column3);
                PrintMatrix(matrix3);
                System.Console.WriteLine();
                PrintMatrix(OrderedInDescending(matrix3));
                break;

            case 56:
                int row5 = Setnumbers("Введите число m");
                int column5 = Setnumbers("Введите число n");
                if (row5 != column5)
                {
                    int[,] matrix5 = GetRandomMatrix(row5, column5);
                    PrintMatrix(matrix5);
                    System.Console.WriteLine();
                    PrintMatrix(FindSummEachRow(matrix5));
                    int[,] sum= FindSummEachRow(matrix5);
                    int minPosition = MinPositionInColumn(sum);
                    System.Console.WriteLine($"{minPosition} строка");
                }
                else { System.Console.WriteLine("Двумерный массив не прямоугольный"); }

                break;
            case 58:
                int rowA = 4;
                int columnA = 2;
                int[,] A = GetRandomMatrix(rowA, columnA, 0, 5);
                PrintMatrix(A);
                System.Console.WriteLine();
                int rowB = 2;
                int columnB = 3;
                int[,] B = GetRandomMatrix(rowB, columnB, 0, 5);
                PrintMatrix(B);
                System.Console.WriteLine();

                if (columnA == rowB) { PrintMatrix(MatrixMultiplication(A, B)); }
                else { System.Console.WriteLine($"Матрицу{A} нельзя умножить на матрицу {B}"); }
                break;

            case 60:
                int[,,] matrix3D = Get3DMatrix();
                Print3DMatrix(matrix3D);
                System.Console.WriteLine();
                break;

            case 62:
                int[,] matrix6 = new int[4, 4];
                PrintMatrix(matrix6);
                System.Console.WriteLine();
                PrintMatrix(SpiralMatrix4X4(matrix6));

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

int[,] OrderedInDescending(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {

                if (matrix[i, j] >= matrix[i, k]) continue;
                {
                    int temp = matrix[i, k];

                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }

    return matrix;
}

int[,] FindSummEachRow(int[,] matrix)
{
    int[,] resultSumm = new int[matrix.GetLength(0), 2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        int k = 0;
        resultSumm[i, k] = i + 1;
        resultSumm[i, k + 1] = sum;
    }
    return resultSumm;
}

int MinPositionInColumn(int[,] matrix)
{
    int minPosition = 1;

    for (int i = 1; i < (matrix.GetLength(0)+1); i++)
    {
        int min = matrix[i, 2];

        if (matrix[i, 2] < min) 
        {
            min = matrix[i, 2];
            minPosition = i;
        }

    }
    return minPosition;
}

int[,] SpiralMatrix4X4(int[,] matrix) //62
{
    int num = 1;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[0, j] = num;
        num++;
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        matrix[i, matrix.GetLength(1) - 1] = num;
        num++;
    }
    for (int j = matrix.GetLength(1) - 2; j >= 0; j--)
    {
        matrix[matrix.GetLength(0) - 1, j] = num;
        num++;
    }
    for (int i = matrix.GetLength(0) - 2; i > 0; i--)
    {
        matrix[i, 0] = num;
        num++;
    }

    while (num < matrix.GetLength(0) * matrix.GetLength(1))
    {
        int k = 1;
        int l = 1;

        while (matrix[k, l + 1] == 0)
        {
            matrix[k, l] = num;
            num++;
            l++;
        }
        while (matrix[k + 1, l] == 0)
        {
            matrix[k, l] = num;
            num++;
            k++;
        }
        while (matrix[k, l - 1] == 0)
        {
            matrix[k, l] = num;
            num++;
            l--;
        }
        while (matrix[k - 1, l] == 0)
        {
            matrix[k, l] = num;
            num++;
            k--;
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0)
            {
                matrix[i, j] = num;
            }
        }
    }
    return matrix;
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2) //58
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }

        }

    }
    return matrix3;
}

int[,,] Get3DMatrix(int x = 2, int y = 2, int z = 2, int begin = 0, int last = 1000) //60
{
    int[,,] matrix = new int[x, y, z];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i, j, k] = begin;
                begin++;
            }

        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine("Page: " + (i + 1));

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            { System.Console.WriteLine(($"num = {matrix[i, j, k]}, индекс=({i},{j},{k})") + " "); }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

