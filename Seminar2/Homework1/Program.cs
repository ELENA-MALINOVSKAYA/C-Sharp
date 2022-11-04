Console.WriteLine("Введите трехзначное число");
int num=Convert.ToInt32(Console.ReadLine());
//int num1= num /100;
int num2= (num/10) % 10;
//int num3= num % 10;


if (num<100 || num>999){
    Console.WriteLine("Введенное число не трехзначное");
}
else {
    Console.WriteLine($"Вторая цифра числа -> {num2}");
}
