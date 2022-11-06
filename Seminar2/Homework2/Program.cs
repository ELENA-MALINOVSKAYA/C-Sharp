Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


if (num<100)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
    for( int i=0; num> 999; i++)
{
     num = num /10;
}
Console.WriteLine($"Третья цифра числа -> {num % 10}");
}
