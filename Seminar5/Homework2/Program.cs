// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] NewArr = GetRandomArray(8);
PrintArray(NewArr);
int sum = SumOddInteger(NewArr);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");


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


int SumOddInteger(int[] arr)
{
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{   
    if(i % 2 != 0)
    {
    sum+=arr[i];
    }
}
return sum;
}