// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] NewArr = GetRandomArray(8,0,10);
PrintArray(NewArr);
double diff = MaxPosition(NewArr)-MinPosition(NewArr);
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diff}");


double[] GetRandomArray(int size, int begin, int last)
{
double[] arr = new double[size];
var random = new Random();

for (int i = 0; i < size; i++)
{
arr[i] = random.Next(begin, last + 1) + random.NextDouble();
}

return arr;
}

void PrintArray(double[] arr)
{
System.Console.WriteLine($"[{String.Join(",",arr)}]");
}

double MinPosition(double[] arr)
{
double min =arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]<min)
    {
        min=arr[i];
    }
}
return min;
}

double MaxPosition(double[] arr)
{
double max =arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>max)
    {
        max=arr[i];
    }
}
return max;
}