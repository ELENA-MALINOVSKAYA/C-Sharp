
                
                string OutputOfNumbersRecursion(int number1, int number2) 
            { 
                if(number1<=number2) return $"{number1} " + OutputOfNumbersRecursion(number1 +1 , number2);
                else return String.Empty;
            }
            int M = Setnumbers("M");
            int N = Setnumbers("N");
                System.Console.WriteLine(OutputOfNumbersRecursion(M,N));


int Setnumbers(string name)
{
    string[] arr = name.Split(" ");
    Console.WriteLine($"Enter numbers {name}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SummRec(int number1, int number2)
{if(number2 == number1) return number2;
else return number2 + SummRec(number1, number2-1);
}
System.Console.WriteLine(SummRec(M,N));