Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();
int [] array = new int[str.Length];
int n = array.Length;

for( int i=0; i< str.Length; i++)
{
     array[i] = int.Parse(str[i].ToString());
}

if (n<3){
    Console.WriteLine("третьей цифры нет");
}
else {
    Console.WriteLine($"Третья цифра числа {num}-> {array[2]}");
}
