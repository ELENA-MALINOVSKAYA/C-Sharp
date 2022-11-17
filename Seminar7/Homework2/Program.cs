// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает индекс этого элемента или 
//же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int num1 = Setnumbers("number");
int[,] matrix1 = GetRandomMatrix();
PrintMatrix(matrix1);
FindIndex(num1, matrix1);

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


void PrintSearchNumber(int num, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {
                System.Console.WriteLine($"i={i},j={j}");
                break; // почему не работает?
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