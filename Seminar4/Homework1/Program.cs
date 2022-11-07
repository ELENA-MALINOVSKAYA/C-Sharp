// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Решение без метода
// Console.WriteLine("Введите 2 числа");

// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());
// int multi = 1;

// for (int i = 1; i <= B; i++)
// {
//     multi *= A;
// }
// Console.WriteLine(multi);

Console.WriteLine("Введите 2 числа");
int result = MultiplicationAB(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
Console.WriteLine(result);

static int MultiplicationAB(int A, int B)
{
int multi = 1;

for (int i = 1; i <= B; i++)
{
    multi *= A;
}
return multi;
}