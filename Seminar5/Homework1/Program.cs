// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] NewArr = GetRandomArray(8, 100, 999);
PrintArray(NewArr);
int count = EvenNumbers(NewArr);
System.Console.WriteLine($"Количество четных чисел в массиве = {count}");


int[] GetRandomArray(int size, int begin = 0, int last = 100)
{
int[] arr = new int[size];
Random random = new Random();

for (int i = 0; i < size; i++)
{
arr[i] = random.Next(begin, last + 1);
}

return arr;
}

void PrintArray(int[] arr)
{
System.Console.WriteLine($"[{String.Join(",",arr)}]");
}


int EvenNumbers(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{    if (arr[i] %2==0)
{
     count++;
}
}
return count;
}

