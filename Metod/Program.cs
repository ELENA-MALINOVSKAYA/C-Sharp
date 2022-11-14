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

void PrintArray1(int[] arr)
{
System.Console.Write($"[{String.Join(", ",arr)}]");
}

Clear();
Write("Введите стороны треугольника через пробел: ");

string[] st=ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

if(IsTriangle(int.Parse(st[0]),int.Parse(st[1]),int.Parse(st[2])))
{
WriteLine("Да");
}
else
{
WriteLine("Нет");
}



bool IsTriangle(int a,int b,int c)
{
return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
}