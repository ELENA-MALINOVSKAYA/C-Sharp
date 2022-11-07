// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

static double TableOfCubes1ToN(double N)
{   
    
    double res = 0;
    for (int i = 1; i <= N; i++) 
    {
    res = Math.Pow(i,3);
    Console.Write($"{res} ");
    }
    return res;
  
}
Console.WriteLine("Введите число:");
double res = TableOfCubes1ToN(double.Parse(Console.ReadLine()));
