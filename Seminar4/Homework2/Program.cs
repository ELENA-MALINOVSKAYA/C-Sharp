// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; num > 9; i++)
{
    sum = sum+ num%10;
}
// for (int i = 0; num > 9; i++)
//{
    num = num/10;
//}
//sum = sum + num;
Console.WriteLine($"Сумма чисел цифры {num} = {sum}");