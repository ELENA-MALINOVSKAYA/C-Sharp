// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите размер массива");

int n = int.Parse(Console.ReadLine());
Console.WriteLine("заполните массив");
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    int element = int.Parse(Console.ReadLine());
    array[i] = element;
    
}
for (int i = 0; i < n; i++)
{
    Console.Write($"{(array[i])}  ");
}