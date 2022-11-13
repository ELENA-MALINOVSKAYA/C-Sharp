GetRandomArray(int size, int begin = 0, int last = 100)
{
int[] arr = new int[size];
Random random = new Random();

for (int i = 0; i < size; i++)
{
arr[i] = random.Next(begin, last + 1);
}

return arr;
}

System.Console.WriteLine(String.Join(",", arr));

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
System.Console.Write(arr[i] + " ");
// System.Console.Write($"{arr[i]} ");
}
}