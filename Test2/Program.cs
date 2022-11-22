int row5 = Setnumbers("Введите число m");
int column5 = Setnumbers("Введите число n");
if (row5 != column5)
{
    int[,] matrix5 = GetRandomMatrix(row5, column5);
    PrintMatrix(matrix5);
    System.Console.WriteLine();
    // PrintMatrix(FindSummEachRow(matrix5));
    // int[,] sum = FindSummEachRow(matrix5);
    // int minPosition = MinPositionInColumn(matrix5);
    // System.Console.WriteLine($"{minPosition} строка");
}
else { System.Console.WriteLine("Двумерный массив не прямоугольный"); }




int MinPositionInColumn(int[,] matrix)
{
    int minPosition = 0;
    int min = matrix[0, 1];

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, 1] < min)
        {
            min = matrix[i, 1];
            minPosition = i;
        }

    }
    return minPosition;
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