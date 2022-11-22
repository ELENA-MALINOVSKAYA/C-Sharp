Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
        Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
 

        int numTask = Setnumbers("task");

        switch (numTask)
        {
            case 0: return; break;
            case 64:
                string OutputOfNumbersRecursion(int number1, int number2) 
            { 
                if(number1<=number2) return OutputOfNumbersRecursion(number1 +1 , number2) +$"{number1} ";
                else return String.Empty;
            }
                System.Console.WriteLine(OutputOfNumbersRecursion(1,Setnumbers("N")));

                break;

            case 66:
                            string OutputOfNumbersRecursion(int number1, int number2) 
            { 
                if(number1<=number2) return $"{number1} " + OutputOfNumbersRecursion(number1 +1 , number2);
                else return String.Empty;
            }
            int M = Setnumbers("M");
            int N = Setnumbers("N");
                System.Console.WriteLine(OutputOfNumbersRecursion(M,N));

                int SummRec(int number1, int number2)
{if(number2 == number1) return number2;
else return number2 + SummRec(number1, number2-1);
}
System.Console.WriteLine(SummRec(M,N));


                break;
            case 68:

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




