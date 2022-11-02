Console.WriteLine("Enter 3 numbers");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
int num3=Convert.ToInt32(Console.ReadLine());
int max=num1;
if (num2>max) max=num2;
if (num3>max) max=num3;

Console.Write("max = ");
Console.WriteLine(max);
