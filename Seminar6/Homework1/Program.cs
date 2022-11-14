// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите число");

int[] array = ArrayConvertStringToInt();
int count = CountPositiveNumbers(array);
Console.WriteLine($"Количество чисел больше 0 ={count}");


int[] ArrayConvertStringToInt()
{
string str = Console.ReadLine();
string[] strArr = str.Split(" ");
int[] array = new int[strArr.Length];

for( int i=0; i< strArr.Length; i++)
{
    array[i] = int.Parse(strArr[i]);
}
return array;
}


int CountPositiveNumbers(int[] arr)
{
int count=0;
for (int i = 0; i < arr.Length; i++)
{   if (arr[i] > 0)
{
    count++;
}
}
return count;
}