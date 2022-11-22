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
                string OutputOfNumbersRecursion1(int numb1, int numb2) 
            { 
                if(numb1<=numb2) return $"{numb1} " + OutputOfNumbersRecursion1(numb1 +1 , numb2);
                else return String.Empty;
            }
                int M = Setnumbers("M");
                int N = Setnumbers("N");
                System.Console.WriteLine(OutputOfNumbersRecursion1(M,N));

                int SummRec(int number1, int number2)
                {if(number2 == number1) return number2;
                else return number2 + SummRec(number1, number2-1);
                }
                System.Console.WriteLine(SummRec(M,N));


                break;
            case 68:


                int Accerman (int m, int n)
                {
                if (m==0) return n+1;
                else if ( m>0 && n==0) return Accerman(m-1,1);
                else return Accerman(m-1,Accerman(m,n-1)); 
                }
                int num1 = Setnumbers("M");
                int num2 = Setnumbers("N");


                System.Console.WriteLine(Accerman(num1,num2));

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
