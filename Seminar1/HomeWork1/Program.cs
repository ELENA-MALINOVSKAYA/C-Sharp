Console.WriteLine("Enter 2 numbers");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
if (num2>num1){
    Console.WriteLine($"min = {num1}, max = {num2}");
}
else {
    Console.WriteLine($"min = {num2}, max = {num1}");
}   
