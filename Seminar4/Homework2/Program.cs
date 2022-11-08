// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int result = SumDigitsInNumber(int.Parse(Console.ReadLine()));
Console.WriteLine($"Сумма чисел цифры = {result}");


static int SumDigitsInNumber (int num)
{
int numA = 0;
int sum = 0;
int count =0;

while (num > 9)
{
    numA = num%10;
    sum += numA;
    num = num / 10;
    count++;
}
sum += num;
return sum;
}