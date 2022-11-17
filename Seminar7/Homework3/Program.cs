// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int row = Setnumbers("m");
int column = Setnumbers("n");
int[,] matrix1 = GetRandomMatrix(row, column);
PrintMatrix(matrix1);
float[] arr1 = FindAvarageEachColumn(matrix1);
PrintArray1(arr1);


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


float[] FindAvarageEachColumn(int[,] matrix)
{
    float[] arr = new float[matrix.GetLength(1)];
    int k = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        float sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[k] = sum/matrix.GetLength(1);
        k++;

    }
return arr;
}

void PrintArray1(float[] arr)
{
    System.Console.Write($"[{String.Join(", ", arr)}]");
}
